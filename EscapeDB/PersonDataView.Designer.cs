namespace EscapeDB
{
    partial class PersonDataView
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
            this.GeneralDataPanel = new System.Windows.Forms.Panel();
            this.StartBlurBtn = new System.Windows.Forms.Button();
            this.JobBox = new System.Windows.Forms.Label();
            this.SexBox = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.Label();
            this.PersonPhoto = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.GeneralDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.Size = new System.Drawing.Size(636, 23);
            // 
            // LeftBorder
            // 
            this.LeftBorder.Size = new System.Drawing.Size(10, 423);
            // 
            // RightBorder
            // 
            this.RightBorder.Location = new System.Drawing.Point(626, 23);
            this.RightBorder.Size = new System.Drawing.Size(10, 423);
            // 
            // BottomBorder
            // 
            this.BottomBorder.Location = new System.Drawing.Point(0, 446);
            this.BottomBorder.Size = new System.Drawing.Size(636, 10);
            // 
            // GeneralDataPanel
            // 
            this.GeneralDataPanel.Controls.Add(this.StartBlurBtn);
            this.GeneralDataPanel.Controls.Add(this.JobBox);
            this.GeneralDataPanel.Controls.Add(this.SexBox);
            this.GeneralDataPanel.Controls.Add(this.AgeBox);
            this.GeneralDataPanel.Controls.Add(this.NameBox);
            this.GeneralDataPanel.Controls.Add(this.PersonPhoto);
            this.GeneralDataPanel.Controls.Add(this.panel3);
            this.GeneralDataPanel.Controls.Add(this.panel2);
            this.GeneralDataPanel.Controls.Add(this.panel1);
            this.GeneralDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralDataPanel.Location = new System.Drawing.Point(10, 23);
            this.GeneralDataPanel.Name = "GeneralDataPanel";
            this.GeneralDataPanel.Size = new System.Drawing.Size(616, 160);
            this.GeneralDataPanel.TabIndex = 4;
            // 
            // StartBlurBtn
            // 
            this.StartBlurBtn.BackColor = System.Drawing.Color.Black;
            this.StartBlurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBlurBtn.ForeColor = System.Drawing.Color.Lime;
            this.StartBlurBtn.Location = new System.Drawing.Point(11, 60);
            this.StartBlurBtn.Name = "StartBlurBtn";
            this.StartBlurBtn.Size = new System.Drawing.Size(103, 36);
            this.StartBlurBtn.TabIndex = 9;
            this.StartBlurBtn.Text = "Vyhledat";
            this.StartBlurBtn.UseVisualStyleBackColor = false;
            this.StartBlurBtn.Click += new System.EventHandler(this.StartBlurBtn_Click);
            // 
            // JobBox
            // 
            this.JobBox.AutoSize = true;
            this.JobBox.Location = new System.Drawing.Point(153, 95);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(49, 13);
            this.JobBox.TabIndex = 8;
            this.JobBox.Text = "Status:";
            this.JobBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SexBox
            // 
            this.SexBox.AutoSize = true;
            this.SexBox.Location = new System.Drawing.Point(147, 48);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(55, 13);
            this.SexBox.TabIndex = 7;
            this.SexBox.Text = "Pohlaví:";
            this.SexBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AgeBox
            // 
            this.AgeBox.AutoSize = true;
            this.AgeBox.Location = new System.Drawing.Point(171, 72);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(31, 13);
            this.AgeBox.TabIndex = 6;
            this.AgeBox.Text = "Věk:";
            this.AgeBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Location = new System.Drawing.Point(159, 25);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(43, 13);
            this.NameBox.TabIndex = 5;
            this.NameBox.Text = "Jméno:";
            this.NameBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PersonPhoto
            // 
            this.PersonPhoto.BackColor = System.Drawing.Color.DimGray;
            this.PersonPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.PersonPhoto.Location = new System.Drawing.Point(5, 5);
            this.PersonPhoto.Name = "PersonPhoto";
            this.PersonPhoto.Size = new System.Drawing.Size(120, 150);
            this.PersonPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PersonPhoto.TabIndex = 0;
            this.PersonPhoto.TabStop = false;
            this.PersonPhoto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PersonPhoto_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 5);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 155);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 5);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.InfoBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(10, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 263);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informace o osobě";
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.InfoBox.HideSelection = false;
            this.InfoBox.Location = new System.Drawing.Point(3, 16);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.Size = new System.Drawing.Size(610, 244);
            this.InfoBox.TabIndex = 0;
            this.InfoBox.Text = "";
            // 
            // PersonDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GeneralDataPanel);
            this.Name = "PersonDataView";
            this.Size = new System.Drawing.Size(636, 456);
            this.Controls.SetChildIndex(this.BottomBorder, 0);
            this.Controls.SetChildIndex(this.TopBorder, 0);
            this.Controls.SetChildIndex(this.LeftBorder, 0);
            this.Controls.SetChildIndex(this.RightBorder, 0);
            this.Controls.SetChildIndex(this.GeneralDataPanel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.GeneralDataPanel.ResumeLayout(false);
            this.GeneralDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralDataPanel;
        private System.Windows.Forms.PictureBox PersonPhoto;
        private System.Windows.Forms.Label SexBox;
        private System.Windows.Forms.Label AgeBox;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label JobBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button StartBlurBtn;
    }
}
