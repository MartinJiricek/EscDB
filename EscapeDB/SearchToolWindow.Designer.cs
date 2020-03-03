namespace EscapeDB
{
    partial class SearchToolWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchControl1 = new EscapeDB.SearchControl();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(15, 567);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(901, 22);
            this.RightPanel.Size = new System.Drawing.Size(15, 567);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(911, 17);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Location = new System.Drawing.Point(5, 589);
            this.BottomPanel.Size = new System.Drawing.Size(911, 15);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(896, 0);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(896, 17);
            this.Header.Text = "Quick Search Engine";
            // 
            // Closer
            // 
            this.Closer.Location = new System.Drawing.Point(896, 0);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.searchControl1);
            this.MainPanel.Size = new System.Drawing.Size(881, 567);
            // 
            // BottomBorder
            // 
            this.BottomBorder.Location = new System.Drawing.Point(5, 604);
            this.BottomBorder.Size = new System.Drawing.Size(911, 5);
            // 
            // RightBorder
            // 
            this.RightBorder.Location = new System.Drawing.Point(916, 5);
            this.RightBorder.Size = new System.Drawing.Size(5, 604);
            // 
            // LeftBorder
            // 
            this.LeftBorder.Size = new System.Drawing.Size(5, 604);
            // 
            // TopBorder
            // 
            this.TopBorder.Size = new System.Drawing.Size(921, 5);
            // 
            // searchControl1
            // 
            this.searchControl1.BackColor = System.Drawing.Color.Black;
            this.searchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchControl1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.ForeColor = System.Drawing.Color.Lime;
            this.searchControl1.Location = new System.Drawing.Point(0, 0);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(881, 567);
            this.searchControl1.TabIndex = 0;
            // 
            // SearchToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 609);
            this.Name = "SearchToolWindow";
            this.Text = "SearchToolWindow";
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SearchControl searchControl1;
    }
}