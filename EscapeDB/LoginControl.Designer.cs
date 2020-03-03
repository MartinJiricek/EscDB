namespace EscapeDB
{
    partial class LoginControl
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
            this.Header = new System.Windows.Forms.Label();
            this.UsernamePanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TopBorder.SuspendLayout();
            this.UsernamePanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.Black;
            this.TopBorder.Controls.Add(this.Header);
            this.TopBorder.Size = new System.Drawing.Size(328, 10);
            // 
            // LeftBorder
            // 
            this.LeftBorder.BackColor = System.Drawing.Color.Black;
            this.LeftBorder.Location = new System.Drawing.Point(0, 10);
            this.LeftBorder.Size = new System.Drawing.Size(10, 111);
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.Color.Black;
            this.RightBorder.Location = new System.Drawing.Point(318, 10);
            this.RightBorder.Size = new System.Drawing.Size(10, 111);
            // 
            // BottomBorder
            // 
            this.BottomBorder.BackColor = System.Drawing.Color.Black;
            this.BottomBorder.Location = new System.Drawing.Point(0, 121);
            this.BottomBorder.Size = new System.Drawing.Size(328, 10);
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.Header.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Header.Size = new System.Drawing.Size(85, 10);
            this.Header.TabIndex = 0;
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernamePanel
            // 
            this.UsernamePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.UsernamePanel.Controls.Add(this.textBox1);
            this.UsernamePanel.Controls.Add(this.label1);
            this.UsernamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsernamePanel.Location = new System.Drawing.Point(10, 32);
            this.UsernamePanel.Name = "UsernamePanel";
            this.UsernamePanel.Size = new System.Drawing.Size(308, 20);
            this.UsernamePanel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(75, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 22);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 10);
            this.panel2.TabIndex = 6;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.PasswordPanel.Controls.Add(this.textBox2);
            this.PasswordPanel.Controls.Add(this.label2);
            this.PasswordPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordPanel.Location = new System.Drawing.Point(10, 62);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(308, 20);
            this.PasswordPanel.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(75, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '○';
            this.textBox2.Size = new System.Drawing.Size(233, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Consolas", 7.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UsernamePanel);
            this.Controls.Add(this.panel1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(328, 131);
            this.Controls.SetChildIndex(this.BottomBorder, 0);
            this.Controls.SetChildIndex(this.TopBorder, 0);
            this.Controls.SetChildIndex(this.LeftBorder, 0);
            this.Controls.SetChildIndex(this.RightBorder, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.UsernamePanel, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.PasswordPanel, 0);
            this.TopBorder.ResumeLayout(false);
            this.UsernamePanel.ResumeLayout(false);
            this.UsernamePanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Panel UsernamePanel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel PasswordPanel;
    }
}
