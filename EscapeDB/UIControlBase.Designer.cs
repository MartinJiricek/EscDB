namespace EscapeDB
{
    partial class UIControlBase
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
            this.TopBorder = new System.Windows.Forms.Panel();
            this.LeftBorder = new System.Windows.Forms.Panel();
            this.RightBorder = new System.Windows.Forms.Panel();
            this.BottomBorder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(364, 23);
            this.TopBorder.TabIndex = 0;
            // 
            // LeftBorder
            // 
            this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorder.Location = new System.Drawing.Point(0, 23);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(10, 184);
            this.LeftBorder.TabIndex = 1;
            // 
            // RightBorder
            // 
            this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder.Location = new System.Drawing.Point(354, 23);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(10, 184);
            this.RightBorder.TabIndex = 2;
            // 
            // BottomBorder
            // 
            this.BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorder.Location = new System.Drawing.Point(0, 207);
            this.BottomBorder.Name = "BottomBorder";
            this.BottomBorder.Size = new System.Drawing.Size(364, 10);
            this.BottomBorder.TabIndex = 3;
            // 
            // UIControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.TopBorder);
            this.Controls.Add(this.BottomBorder);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "UIControlBase";
            this.Size = new System.Drawing.Size(364, 217);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TopBorder;
        public System.Windows.Forms.Panel LeftBorder;
        public System.Windows.Forms.Panel RightBorder;
        public System.Windows.Forms.Panel BottomBorder;
    }
}
