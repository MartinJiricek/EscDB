namespace EscapeDB
{
    partial class LoadingBarDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(15, 57);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(649, 22);
            this.RightPanel.Size = new System.Drawing.Size(15, 57);
            // 
            // TopPanel
            // 
            this.TopPanel.Location = new System.Drawing.Point(5, 5);
            this.TopPanel.Size = new System.Drawing.Size(659, 17);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Location = new System.Drawing.Point(5, 79);
            this.BottomPanel.Size = new System.Drawing.Size(659, 15);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(644, 0);
            this.Resizer.Visible = false;
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(644, 17);
            this.Header.Text = "Vyhledávám shodu:";
            // 
            // Closer
            // 
            this.Closer.Location = new System.Drawing.Point(644, 0);
            this.Closer.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Location = new System.Drawing.Point(20, 22);
            this.MainPanel.Size = new System.Drawing.Size(629, 57);
            // 
            // BottomBorder
            // 
            this.BottomBorder.Location = new System.Drawing.Point(5, 94);
            this.BottomBorder.Size = new System.Drawing.Size(659, 5);
            // 
            // RightBorder
            // 
            this.RightBorder.Location = new System.Drawing.Point(664, 5);
            this.RightBorder.Size = new System.Drawing.Size(5, 94);
            // 
            // LeftBorder
            // 
            this.LeftBorder.Size = new System.Drawing.Size(5, 94);
            // 
            // TopBorder
            // 
            this.TopBorder.Size = new System.Drawing.Size(669, 5);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 20);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.Bar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 17);
            this.panel2.TabIndex = 1;
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(629, 17);
            this.Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Bar.TabIndex = 0;
            this.Bar.Value = 50;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 20);
            this.panel3.TabIndex = 2;
            // 
            // LoadingBarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 99);
            this.Name = "LoadingBarDialog";
            this.Text = "LoadingBarDialog";
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar Bar;
    }
}