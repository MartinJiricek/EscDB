namespace EscapeDB
{
    internal partial class LoginDialog : WindowBase
    {


        public LoginDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.loginControl1 = new EscapeDB.LoginControl();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // LeftPanel
            //
            this.LeftPanel.Size = new System.Drawing.Size(15, 122);
            //
            // RightPanel
            //
            this.RightPanel.Location = new System.Drawing.Point(385, 23);
            this.RightPanel.Size = new System.Drawing.Size(15, 122);
            //
            // TopPanel
            //
            this.TopPanel.Size = new System.Drawing.Size(400, 23);
            //
            // BottomPanel
            //
            this.BottomPanel.Location = new System.Drawing.Point(0, 145);
            this.BottomPanel.Size = new System.Drawing.Size(400, 15);
            //
            // Resizer
            //
            this.Resizer.Location = new System.Drawing.Point(385, 0);
            //
            // Header
            //
            this.Header.Size = new System.Drawing.Size(385, 23);
            this.Header.Text = "";
            //
            // Closer
            //
            this.Closer.Location = new System.Drawing.Point(385, 0);
            //
            // MainPanel
            //
            this.MainPanel.Controls.Add(this.loginControl1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Size = new System.Drawing.Size(370, 93);
            //
            // loginControl1
            //
            this.loginControl1.BackColor = System.Drawing.Color.Black;
            this.loginControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginControl1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginControl1.ForeColor = System.Drawing.Color.Lime;
            this.loginControl1.Location = new System.Drawing.Point(0, 0);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(370, 93);
            this.loginControl1.TabIndex = 0;
            //
            // LoginDialog
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 160);
            this.MaximumSize = new System.Drawing.Size(700, 160);
            this.MinimumSize = new System.Drawing.Size(400, 160);
            this.Name = "LoginDialog";
            this.TopMost = true;
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}