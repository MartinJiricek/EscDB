namespace EscapeDB
{
    partial class MainWindow
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
            this.LeftEdge = new System.Windows.Forms.Panel();
            this.TopEdge = new System.Windows.Forms.Panel();
            this.RightEdge = new System.Windows.Forms.Panel();
            this.BotomEdge = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LoginBox = new EscapeDB.LoginTransparent();
            this.EditorBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftEdge
            // 
            this.LeftEdge.BackColor = System.Drawing.Color.Black;
            this.LeftEdge.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftEdge.Location = new System.Drawing.Point(0, 31);
            this.LeftEdge.Name = "LeftEdge";
            this.LeftEdge.Size = new System.Drawing.Size(5, 611);
            this.LeftEdge.TabIndex = 0;
            this.LeftEdge.Visible = false;
            // 
            // TopEdge
            // 
            this.TopEdge.BackColor = System.Drawing.Color.Black;
            this.TopEdge.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopEdge.Location = new System.Drawing.Point(0, 0);
            this.TopEdge.Name = "TopEdge";
            this.TopEdge.Size = new System.Drawing.Size(768, 31);
            this.TopEdge.TabIndex = 1;
            this.TopEdge.Visible = false;
            // 
            // RightEdge
            // 
            this.RightEdge.BackColor = System.Drawing.Color.Black;
            this.RightEdge.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightEdge.Location = new System.Drawing.Point(763, 31);
            this.RightEdge.Name = "RightEdge";
            this.RightEdge.Size = new System.Drawing.Size(5, 611);
            this.RightEdge.TabIndex = 2;
            this.RightEdge.Visible = false;
            // 
            // BotomEdge
            // 
            this.BotomEdge.BackColor = System.Drawing.Color.Black;
            this.BotomEdge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotomEdge.Location = new System.Drawing.Point(0, 642);
            this.BotomEdge.Name = "BotomEdge";
            this.BotomEdge.Size = new System.Drawing.Size(768, 5);
            this.BotomEdge.TabIndex = 3;
            this.BotomEdge.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = global::EscapeDB.Properties.Resources.BW_Simple;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.Controls.Add(this.LoginBox);
            this.MainPanel.Controls.Add(this.EditorBtn);
            this.MainPanel.Controls.Add(this.SearchBtn);
            this.MainPanel.Controls.Add(this.CloseBtn);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(5, 31);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(758, 611);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginBox.Location = new System.Drawing.Point(318, 360);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(381, 70);
            this.LoginBox.TabIndex = 4;
            // 
            // EditorBtn
            // 
            this.EditorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EditorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.EditorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditorBtn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditorBtn.ForeColor = System.Drawing.Color.Lime;
            this.EditorBtn.Location = new System.Drawing.Point(6, 354);
            this.EditorBtn.Name = "EditorBtn";
            this.EditorBtn.Size = new System.Drawing.Size(121, 22);
            this.EditorBtn.TabIndex = 3;
            this.EditorBtn.Text = "EDITOR";
            this.EditorBtn.UseVisualStyleBackColor = true;
            this.EditorBtn.Visible = false;
            this.EditorBtn.Click += new System.EventHandler(this.EditorBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Lime;
            this.SearchBtn.Location = new System.Drawing.Point(6, 326);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(120, 22);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "DATABASE";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Visible = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Red;
            this.CloseBtn.Location = new System.Drawing.Point(7, 408);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(121, 22);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "CLOSE";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Visible = false;
            this.CloseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(768, 647);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.RightEdge);
            this.Controls.Add(this.LeftEdge);
            this.Controls.Add(this.TopEdge);
            this.Controls.Add(this.BotomEdge);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftEdge;
        private System.Windows.Forms.Panel TopEdge;
        private System.Windows.Forms.Panel RightEdge;
        private System.Windows.Forms.Panel BotomEdge;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button EditorBtn;
        private LoginTransparent LoginBox;
    }
}