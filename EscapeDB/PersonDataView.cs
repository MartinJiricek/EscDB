using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EscapeDB
{
    public partial class PersonDataView : UIControlBase
    {
        public PersonalData Data { get; set; }

        Graphics _gfx;

        private Image _original;
        private Image _modified;

        private List<Image> _modList = new List<Image>();

        private Timer _photoUpdater = new Timer();



        public PersonDataView()
        {
            InitializeComponent();
            LoadPhotoUpdater();
            LoadPerson(new PersonalData());
            _gfx = PersonPhoto.CreateGraphics();
            _gfx.CompositingMode = CompositingMode.SourceOver;
            _gfx.CompositingQuality = CompositingQuality.HighSpeed;
            _gfx.InterpolationMode = InterpolationMode.Low;
            _gfx.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            _gfx.SmoothingMode = SmoothingMode.HighSpeed;


        }

        private void LoadPhotoUpdater()
        {
            _photoUpdater.Interval = 1;
            _photoUpdater.Tick += _photoUpdater_Tick;
        }

        private void _photoUpdater_Tick(object sender, EventArgs e)
        {
            DrawRandomOriginalRectangle();
            DrawRandomBlurRectangle();
        }

        public void LoadPerson(PersonalData personData)
        {
            Data = personData;
            Visible = true;
            UpdateControls();
        }

        public void UpdateControls()
        {
            NameBox.Text = "Jméno: " + Data.Name;
            AgeBox.Text = "Věk: " + Data.Age;
            SexBox.Text = "Pohlaví: " + Data.Sex;
            JobBox.Text = "Status: " + Data.Job;
            InfoBox.Text = Data.PersonalInfo;

        }

        public void LoadPhoto(Image photo)
        {
            _original = photo;
            _modified = PixelateImage(photo,10);

            PersonPhoto.Image = _modified;

            LoadImageList(photo, 10);
        }

        private void LoadImageList(Image photo, int count)
        {
            int offset = 3;
            for(int i = offset; i < count + offset; i++)
            {
                _modList.Add(PixelateImage(photo, i));
            }
        }

        public void LoadConfiguration()
        {
            Configuration cfg = new Configuration();

            NameBox.ForeColor = cfg.GeneralButtonForeColor;
            NameBox.Font = cfg.GeneralButtonFont;
            NameBox.BackColor = cfg.GeneralButtonBackColor;

            AgeBox.ForeColor = cfg.GeneralButtonForeColor;
            AgeBox.Font = cfg.GeneralButtonFont;
            AgeBox.BackColor = cfg.GeneralButtonBackColor;

            SexBox.ForeColor = cfg.GeneralButtonForeColor;
            SexBox.Font = cfg.GeneralButtonFont;
            SexBox.BackColor = cfg.GeneralButtonBackColor;

            JobBox.ForeColor = cfg.GeneralButtonForeColor;
            JobBox.Font = cfg.GeneralButtonFont;
            JobBox.BackColor = cfg.GeneralButtonBackColor;

            groupBox1.ForeColor = cfg.GeneralButtonForeColor;
            groupBox1.Font = cfg.GeneralButtonFont;
            groupBox1.BackColor = cfg.GeneralButtonBackColor;

            InfoBox.ForeColor = cfg.GeneralContentBackColor;
            InfoBox.Font = cfg.GeneralContentFont;
            InfoBox.BackColor = cfg.GeneralContentBackColor;

            PersonPhoto.BackColor = cfg.GeneralContentBackColor;

        }

        private Image PixelateImage(Image image, int scale = 4)
        {
            int wid = image.Width;
            int hei = image.Height;

            if (scale < 1)
                scale = 1;
            else if (scale >= Math.Min(wid, hei))
                scale = 4;

            Bitmap small = new Bitmap(image, wid/scale, hei/scale);

            return new Bitmap(small, wid, hei);
        }


        private void PersonPhoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StartPixelation();
        }

        private void StartPixelation()
        {

            if (_original != null)
            {
                LoadingBarDialog win = new LoadingBarDialog();
                win.FormClosed += Win_FormClosed;
                win.Show();
                _photoUpdater.Start();
            }

        }

        private void Win_FormClosed(object sender, FormClosedEventArgs e)
        {
            _photoUpdater.Stop();
            PersonPhoto.Image = _original;
        }

        public void DrawOriginalRectangle(int x, int y, int width, int height)
        {
            Rectangle sourceRect = new Rectangle(x, y, width, height);
            _gfx.DrawImage(_original, x, y, sourceRect, GraphicsUnit.Pixel);
        }

            public void DrawRandomOriginalRectangle()
        {
            int wid = xRandom.Get(1, PersonPhoto.Width / 10);
            int hei = xRandom.Get(1, PersonPhoto.Height / 10);
            int x = xRandom.Get(0, PersonPhoto.Width - wid);
            int y = xRandom.Get(0, PersonPhoto.Height - hei);

            DrawOriginalRectangle(x, y, wid, hei);
        }

        public void DrawBlurRectangle(int x, int y, int width, int height)
        {
            Rectangle sourceRect = new Rectangle(x, y, width, height);
            _gfx.DrawImage(_modified, x, y, sourceRect, GraphicsUnit.Pixel);
        }

        public void DrawBlurRectangle(int x, int y, int width, int height, int blurIndex)
        {
            blurIndex = Math.Min(_modList.Count - 1, blurIndex);
            blurIndex = Math.Max(0, blurIndex);

            Rectangle sourceRect = new Rectangle(x, y, width, height);
            _gfx.DrawImage(_modList[blurIndex], x, y, sourceRect, GraphicsUnit.Pixel);
        }

        public void DrawRandomBlurRectangle()
        {
            int count = xRandom.Get(1, 2);
            for (int i = 0; i < count; i++)
            {

                int wid = xRandom.Get(1, PersonPhoto.Width / 5);
                int hei = xRandom.Get(1, PersonPhoto.Height / 5);
                int x = xRandom.Get(0, PersonPhoto.Width - wid);
                int y = xRandom.Get(0, PersonPhoto.Height - hei);
                int blurIndex = xRandom.Get(0, _modList.Count - 1);

                DrawBlurRectangle(x, y, wid, hei,blurIndex);
            }
        }

        public void DrawRandomBlurRectangle(int blurIndex)
        {
            int count = xRandom.Get(1, 2);
            for (int i = 0; i < count; i++)
            {

                int wid = xRandom.Get(1, PersonPhoto.Width / 5);
                int hei = xRandom.Get(1, PersonPhoto.Height / 5);
                int x = xRandom.Get(0, PersonPhoto.Width - wid);
                int y = xRandom.Get(0, PersonPhoto.Height - hei);

                DrawBlurRectangle(x, y, wid, hei,blurIndex);
            }
        }

        private void StartBlurBtn_Click(object sender, EventArgs e)
        {
            if (Data.Photo != null)
            {
                LoadPhoto(Data.Photo);
                StartBlurBtn.Visible = false;
                StartPixelation();
            }
            else
            {
                StartBlurBtn.ForeColor = Color.Red;
                StartBlurBtn.Text = "Nenalezeno!";
               // StartBlurBtn.Enabled = false;
            }
        }
    }
}