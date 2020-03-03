namespace EscapeDB
{
    partial class WindowBase
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Label();
            this.Closer = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Resizer = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomBorder = new System.Windows.Forms.Panel();
            this.RightBorder = new System.Windows.Forms.Panel();
            this.LeftBorder = new System.Windows.Forms.Panel();
            this.TopBorder = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(5, 22);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(15, 222);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(530, 22);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(15, 222);
            this.RightPanel.TabIndex = 1;
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TopPanel.Controls.Add(this.Header);
            this.TopPanel.Controls.Add(this.Closer);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(5, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(540, 17);
            this.TopPanel.TabIndex = 2;
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Header.Size = new System.Drawing.Size(525, 17);
            this.Header.TabIndex = 4;
            this.Header.Text = "Window Base";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            // 
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Closer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closer.Dock = System.Windows.Forms.DockStyle.Right;
            this.Closer.Location = new System.Drawing.Point(525, 0);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(15, 17);
            this.Closer.TabIndex = 3;
            this.Closer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Closer_MouseClick);
            this.Closer.MouseEnter += new System.EventHandler(this.Closer_MouseEnter);
            this.Closer.MouseLeave += new System.EventHandler(this.Closer_MouseLeave);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BottomPanel.Controls.Add(this.Resizer);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(5, 244);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(540, 15);
            this.BottomPanel.TabIndex = 3;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            // 
            // Resizer
            // 
            this.Resizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.Resizer.Dock = System.Windows.Forms.DockStyle.Right;
            this.Resizer.Location = new System.Drawing.Point(525, 0);
            this.Resizer.Name = "Resizer";
            this.Resizer.Size = new System.Drawing.Size(15, 15);
            this.Resizer.TabIndex = 2;
            this.Resizer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resizer_MouseDown);
            this.Resizer.MouseEnter += new System.EventHandler(this.Resizer_MouseEnter);
            this.Resizer.MouseLeave += new System.EventHandler(this.Resizer_MouseLeave);
            this.Resizer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resizer_MouseMove);
            this.Resizer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resizer_MouseUp);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(20, 22);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(510, 222);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            // 
            // BottomBorder
            // 
            this.BottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorder.Location = new System.Drawing.Point(5, 259);
            this.BottomBorder.Name = "BottomBorder";
            this.BottomBorder.Size = new System.Drawing.Size(540, 5);
            this.BottomBorder.TabIndex = 5;
            this.BottomBorder.Visible = false;
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder.Location = new System.Drawing.Point(545, 5);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(5, 259);
            this.RightBorder.TabIndex = 6;
            this.RightBorder.Visible = false;
            // 
            // LeftBorder
            // 
            this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorder.Location = new System.Drawing.Point(0, 5);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(5, 259);
            this.LeftBorder.TabIndex = 7;
            this.LeftBorder.Visible = false;
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(550, 5);
            this.TopBorder.TabIndex = 8;
            this.TopBorder.Visible = false;
            // 
            // WindowBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 264);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.BottomBorder);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.TopBorder);
            this.Font = new System.Drawing.Font("Consolas", 8F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WindowBase";
            this.Text = "WindowBase";
            this.TopMost = true;
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel LeftPanel;
        public System.Windows.Forms.Panel RightPanel;
        public System.Windows.Forms.Panel TopPanel;
        public System.Windows.Forms.Panel BottomPanel;
        public System.Windows.Forms.Panel Resizer;
        public System.Windows.Forms.Label Header;
        public System.Windows.Forms.Panel Closer;
        public System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Panel BottomBorder;
        public System.Windows.Forms.Panel RightBorder;
        public System.Windows.Forms.Panel LeftBorder;
        public System.Windows.Forms.Panel TopBorder;
    }
}