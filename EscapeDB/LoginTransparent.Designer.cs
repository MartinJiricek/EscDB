namespace EscapeDB
{
    partial class LoginTransparent
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
            this.HeaderBox = new System.Windows.Forms.Label();
            this.PwdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeaderBox
            // 
            this.HeaderBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderBox.Location = new System.Drawing.Point(0, 0);
            this.HeaderBox.Name = "HeaderBox";
            this.HeaderBox.Size = new System.Drawing.Size(265, 36);
            this.HeaderBox.TabIndex = 3;
            this.HeaderBox.Text = "Zadej uživatelský klíč:";
            this.HeaderBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PwdBox
            // 
            this.PwdBox.BackColor = System.Drawing.Color.Black;
            this.PwdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PwdBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PwdBox.ForeColor = System.Drawing.Color.Lime;
            this.PwdBox.Location = new System.Drawing.Point(0, 36);
            this.PwdBox.Name = "PwdBox";
            this.PwdBox.PasswordChar = 'x';
            this.PwdBox.ShortcutsEnabled = false;
            this.PwdBox.Size = new System.Drawing.Size(265, 26);
            this.PwdBox.TabIndex = 4;
            this.PwdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PwdBox_KeyDown);
            // 
            // LoginTransparent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PwdBox);
            this.Controls.Add(this.HeaderBox);
            this.Name = "LoginTransparent";
            this.Size = new System.Drawing.Size(265, 70);
            this.Load += new System.EventHandler(this.LoginTransparent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HeaderBox;
        private System.Windows.Forms.TextBox PwdBox;
    }
}
