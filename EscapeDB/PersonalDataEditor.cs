using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EscapeDB
{
    public partial class PersonalDataEditor : UIControlBase
    {
        public PersonalData Data { get; set; }
        public static List<PersonalData> AvailablePersons { get { return PersonalDataManager.GetAvailablePersons(); } }

        private Color _photoLightTone = Color.Lime;
        private Color _photoDarkTone = Color.Black;
        private int _btThreshold = 500;
        private Image _photo;

        public PersonalDataEditor()
        {
            InitializeComponent();
            Data = new PersonalData();
            LoadExisting();
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            Configuration cfg = new Configuration();

            NewBtn.ForeColor = cfg.GeneralButtonForeColor;
            SaveBtn.ForeColor = cfg.GeneralButtonForeColor;
            LoadPhotoBtn.ForeColor = cfg.GeneralButtonForeColor;
            DeleteBtn.ForeColor = cfg.GeneralButtonForeColor;
            ExistingPersonsBox.ForeColor = cfg.GeneralButtonForeColor;
            LabelName.ForeColor = cfg.GeneralButtonForeColor;
            LabelSex.ForeColor = cfg.GeneralButtonForeColor;
            LabelAge.ForeColor = cfg.GeneralButtonForeColor;
            LabelJob.ForeColor = cfg.GeneralButtonForeColor;

            BackColor = cfg.GetColor("EditorBackColor", BackColor);

            PersonPhoto.BackColor = cfg.GetColor("EditorContentBackColor", PersonPhoto.BackColor);
            NameBox.BackColor = cfg.GetColor("EditorContentBackColor", NameBox.BackColor);
            SexBox.BackColor = cfg.GetColor("EditorContentBackColor", SexBox.BackColor);
            AgeBox.BackColor = cfg.GetColor("EditorContentBackColor", AgeBox.BackColor);
            JobBox.BackColor = cfg.GetColor("EditorContentBackColor", JobBox.BackColor);

            NameBox.ForeColor = cfg.GetColor("EditorForeColor", NameBox.ForeColor);
            SexBox.ForeColor = cfg.GetColor("EditorForeColor", SexBox.ForeColor);
            AgeBox.ForeColor = cfg.GetColor("EditorForeColor", AgeBox.ForeColor);
            JobBox.ForeColor = cfg.GetColor("EditorForeColor", JobBox.ForeColor);

            _photoLightTone = cfg.GetColor("PhotoLightTone", _photoLightTone);
            _photoDarkTone = cfg.GetColor("PhotoDarkTone", _photoDarkTone);
            _btThreshold = cfg.GetInteger("BitonalThreshold", _btThreshold);
        }

        public Bitmap Bitonal(Bitmap sourceBitmap, Color darkColor, Color lightColor, int threshold)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                if (pixelBuffer[k] + pixelBuffer[k + 1] + pixelBuffer[k + 2] <= threshold)
                {
                    pixelBuffer[k] = darkColor.B;
                    pixelBuffer[k + 1] = darkColor.G;
                    pixelBuffer[k + 2] = darkColor.R;
                }
                else
                {
                    pixelBuffer[k] = lightColor.B;
                    pixelBuffer[k + 1] = lightColor.G;
                    pixelBuffer[k + 2] = lightColor.R;
                }
            }
            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length); resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            Data = new PersonalData();
        }

        private void LoadPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            ofd.ShowDialog();

            if (File.Exists(ofd.FileName))
            {
                _photo = Image.FromFile(ofd.FileName);
                PersonPhoto.Image = _photo;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PersonPhoto.Image != null)
                Data.Photo = new Bitmap(PersonPhoto.Image, PersonPhoto.Width, PersonPhoto.Height);
            PersonalDataManager.SavePerson(Data, "CS");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
        }

        private void TresholdBox_ValueChanged(object sender, EventArgs e)
        {
            PersonPhoto.Image = Bitonal(new Bitmap(_photo), _photoDarkTone, _photoLightTone, (int)TresholdBox.Value);
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (Data == null)
                Data = new PersonalData();

            Data.Name = NameBox.Text;
        }

        private void SexBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Data == null)
                Data = new PersonalData();
            Data.Sex = SexBox.Text;
        }

        private void AgeBox_ValueChanged(object sender, EventArgs e)
        {
            if (Data == null)
                Data = new PersonalData();
            Data.Age = (int)AgeBox.Value;
        }

        private void JobBox_TextChanged(object sender, EventArgs e)
        {
            if (Data == null)
                Data = new PersonalData();
            Data.Job = JobBox.Text;
        }

        public void LoadExisting()
        {
            ExistingPersonsBox.Items.Clear();
            for (int i = 0; i < AvailablePersons.Count; i++)
            {
                if (AvailablePersons[i] != null)
                    ExistingPersonsBox.Items.Add(AvailablePersons[i].Name);
            }
        }

        private void ExistingPersonsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadPerson(AvailablePersons[ExistingPersonsBox.SelectedIndex]);
            }
            catch { }
        }

        public void LoadPerson(PersonalData person)
        {
            Data = person;
            NameBox.Text = person.Name;
            AgeBox.Value = person.Age;

            switch (SexBox.SelectedText.ToLower())
            {
                case "male":
                    SexBox.SelectedItem = 0;
                    break;

                case "female":
                    SexBox.SelectedItem = 1;
                    break;
            }

            JobBox.Text = person.Job;
            InfoBox.Text = person.PersonalInfo;

            if (person.Photo != null)
                PersonPhoto.Image = person.Photo;
        }

        private void InfoBox_TextChanged(object sender, EventArgs e)
        {
            Data.PersonalInfo = InfoBox.Text;
        }
    }
}