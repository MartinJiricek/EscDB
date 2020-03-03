namespace EscapeDB
{
    partial class PersonalDataEditor
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelJob = new System.Windows.Forms.Label();
            this.LabelSex = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.GeneralDataPanel = new System.Windows.Forms.Panel();
            this.TresholdBox = new System.Windows.Forms.NumericUpDown();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.AgeBox = new System.Windows.Forms.NumericUpDown();
            this.JobBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PersonPhoto = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExistingPersonsBox = new System.Windows.Forms.ComboBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadPhotoBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.TopBorder.SuspendLayout();
            this.GeneralDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TresholdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPhoto)).BeginInit();
            this.DataGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.Controls.Add(this.panel4);
            this.TopBorder.Location = new System.Drawing.Point(10, 0);
            this.TopBorder.Size = new System.Drawing.Size(527, 33);
            // 
            // LeftBorder
            // 
            this.LeftBorder.Location = new System.Drawing.Point(0, 0);
            this.LeftBorder.Size = new System.Drawing.Size(10, 553);
            // 
            // RightBorder
            // 
            this.RightBorder.Location = new System.Drawing.Point(537, 0);
            this.RightBorder.Size = new System.Drawing.Size(10, 553);
            // 
            // BottomBorder
            // 
            this.BottomBorder.Location = new System.Drawing.Point(10, 543);
            this.BottomBorder.Size = new System.Drawing.Size(527, 10);
            // 
            // LabelJob
            // 
            this.LabelJob.AutoSize = true;
            this.LabelJob.Location = new System.Drawing.Point(137, 95);
            this.LabelJob.Name = "LabelJob";
            this.LabelJob.Size = new System.Drawing.Size(49, 13);
            this.LabelJob.TabIndex = 8;
            this.LabelJob.Text = "Status:";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Location = new System.Drawing.Point(134, 48);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(55, 13);
            this.LabelSex.TabIndex = 7;
            this.LabelSex.Text = "Pohlaví:";
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(157, 72);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(31, 13);
            this.LabelAge.TabIndex = 6;
            this.LabelAge.Text = "Věk:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(147, 25);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(43, 13);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Jméno:";
            // 
            // GeneralDataPanel
            // 
            this.GeneralDataPanel.Controls.Add(this.TresholdBox);
            this.GeneralDataPanel.Controls.Add(this.SexBox);
            this.GeneralDataPanel.Controls.Add(this.AgeBox);
            this.GeneralDataPanel.Controls.Add(this.JobBox);
            this.GeneralDataPanel.Controls.Add(this.NameBox);
            this.GeneralDataPanel.Controls.Add(this.LabelJob);
            this.GeneralDataPanel.Controls.Add(this.LabelSex);
            this.GeneralDataPanel.Controls.Add(this.LabelAge);
            this.GeneralDataPanel.Controls.Add(this.LabelName);
            this.GeneralDataPanel.Controls.Add(this.PersonPhoto);
            this.GeneralDataPanel.Controls.Add(this.panel3);
            this.GeneralDataPanel.Controls.Add(this.panel2);
            this.GeneralDataPanel.Controls.Add(this.panel1);
            this.GeneralDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralDataPanel.Location = new System.Drawing.Point(10, 33);
            this.GeneralDataPanel.Name = "GeneralDataPanel";
            this.GeneralDataPanel.Size = new System.Drawing.Size(527, 156);
            this.GeneralDataPanel.TabIndex = 5;
            // 
            // TresholdBox
            // 
            this.TresholdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TresholdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TresholdBox.ForeColor = System.Drawing.Color.Lime;
            this.TresholdBox.Location = new System.Drawing.Point(190, 118);
            this.TresholdBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TresholdBox.Name = "TresholdBox";
            this.TresholdBox.Size = new System.Drawing.Size(67, 16);
            this.TresholdBox.TabIndex = 15;
            this.TresholdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TresholdBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TresholdBox.ValueChanged += new System.EventHandler(this.TresholdBox_ValueChanged);
            // 
            // SexBox
            // 
            this.SexBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SexBox.ForeColor = System.Drawing.SystemColors.Info;
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Items.AddRange(new object[] {
            "Muž",
            "Žena"});
            this.SexBox.Location = new System.Drawing.Point(190, 45);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(67, 21);
            this.SexBox.TabIndex = 14;
            this.SexBox.Text = ". . . .";
            this.SexBox.SelectedIndexChanged += new System.EventHandler(this.SexBox_SelectedIndexChanged);
            // 
            // AgeBox
            // 
            this.AgeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.AgeBox.ForeColor = System.Drawing.SystemColors.Info;
            this.AgeBox.Location = new System.Drawing.Point(190, 68);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(67, 20);
            this.AgeBox.TabIndex = 13;
            this.AgeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgeBox.ValueChanged += new System.EventHandler(this.AgeBox_ValueChanged);
            // 
            // JobBox
            // 
            this.JobBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.JobBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JobBox.ForeColor = System.Drawing.SystemColors.Info;
            this.JobBox.Location = new System.Drawing.Point(190, 92);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(281, 20);
            this.JobBox.TabIndex = 12;
            this.JobBox.Text = "N/A";
            this.JobBox.TextChanged += new System.EventHandler(this.JobBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.ForeColor = System.Drawing.SystemColors.Info;
            this.NameBox.Location = new System.Drawing.Point(190, 22);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(281, 20);
            this.NameBox.TabIndex = 9;
            this.NameBox.Text = "N/A";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // PersonPhoto
            // 
            this.PersonPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PersonPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.PersonPhoto.Location = new System.Drawing.Point(5, 5);
            this.PersonPhoto.Name = "PersonPhoto";
            this.PersonPhoto.Size = new System.Drawing.Size(118, 146);
            this.PersonPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonPhoto.TabIndex = 0;
            this.PersonPhoto.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 5);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 151);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 5);
            this.panel1.TabIndex = 1;
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.BackColor = System.Drawing.Color.Black;
            this.DataGroupBox.Controls.Add(this.InfoBox);
            this.DataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGroupBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataGroupBox.ForeColor = System.Drawing.Color.Lime;
            this.DataGroupBox.Location = new System.Drawing.Point(10, 189);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(527, 354);
            this.DataGroupBox.TabIndex = 6;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Informace o osobě";
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoBox.ForeColor = System.Drawing.SystemColors.Info;
            this.InfoBox.HideSelection = false;
            this.InfoBox.Location = new System.Drawing.Point(3, 16);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(521, 335);
            this.InfoBox.TabIndex = 0;
            this.InfoBox.Text = "Prostor pro záznam . . .";
            this.InfoBox.TextChanged += new System.EventHandler(this.InfoBox_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ExistingPersonsBox);
            this.panel4.Controls.Add(this.DeleteBtn);
            this.panel4.Controls.Add(this.SaveBtn);
            this.panel4.Controls.Add(this.LoadPhotoBtn);
            this.panel4.Controls.Add(this.NewBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 21);
            this.panel4.TabIndex = 0;
            // 
            // ExistingPersonsBox
            // 
            this.ExistingPersonsBox.BackColor = System.Drawing.Color.Black;
            this.ExistingPersonsBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExistingPersonsBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExistingPersonsBox.ForeColor = System.Drawing.Color.Lime;
            this.ExistingPersonsBox.FormattingEnabled = true;
            this.ExistingPersonsBox.ItemHeight = 13;
            this.ExistingPersonsBox.Items.AddRange(new object[] {
            "N/A",
            "N/A",
            "N/A",
            "N/A"});
            this.ExistingPersonsBox.Location = new System.Drawing.Point(313, 0);
            this.ExistingPersonsBox.Name = "ExistingPersonsBox";
            this.ExistingPersonsBox.Size = new System.Drawing.Size(214, 21);
            this.ExistingPersonsBox.TabIndex = 3;
            this.ExistingPersonsBox.Text = "Existující záznamy";
            this.ExistingPersonsBox.SelectedIndexChanged += new System.EventHandler(this.ExistingPersonsBox_SelectedIndexChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(257, 0);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(56, 21);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Smazat";
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(178, 0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(79, 21);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Ulož do DB";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadPhotoBtn
            // 
            this.LoadPhotoBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadPhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPhotoBtn.Location = new System.Drawing.Point(84, 0);
            this.LoadPhotoBtn.Name = "LoadPhotoBtn";
            this.LoadPhotoBtn.Size = new System.Drawing.Size(94, 21);
            this.LoadPhotoBtn.TabIndex = 1;
            this.LoadPhotoBtn.Text = "Nahrát fotku";
            this.LoadPhotoBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadPhotoBtn.UseVisualStyleBackColor = true;
            this.LoadPhotoBtn.Click += new System.EventHandler(this.LoadPhotoBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBtn.ForeColor = System.Drawing.Color.Lime;
            this.NewBtn.Location = new System.Drawing.Point(0, 0);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(84, 21);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "Nový záznam";
            this.NewBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // PersonalDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGroupBox);
            this.Controls.Add(this.GeneralDataPanel);
            this.Name = "PersonalDataEditor";
            this.Size = new System.Drawing.Size(547, 553);
            this.Controls.SetChildIndex(this.RightBorder, 0);
            this.Controls.SetChildIndex(this.LeftBorder, 0);
            this.Controls.SetChildIndex(this.BottomBorder, 0);
            this.Controls.SetChildIndex(this.TopBorder, 0);
            this.Controls.SetChildIndex(this.GeneralDataPanel, 0);
            this.Controls.SetChildIndex(this.DataGroupBox, 0);
            this.TopBorder.ResumeLayout(false);
            this.GeneralDataPanel.ResumeLayout(false);
            this.GeneralDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TresholdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPhoto)).EndInit();
            this.DataGroupBox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelJob;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.PictureBox PersonPhoto;
        private System.Windows.Forms.Panel GeneralDataPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox ExistingPersonsBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadPhotoBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.NumericUpDown AgeBox;
        private System.Windows.Forms.TextBox JobBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.NumericUpDown TresholdBox;
    }
}
