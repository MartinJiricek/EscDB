using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EscapeDB
{
    public partial class LoginTransparent : UserControl
    {
        public string AdminPWD { get; private set; } = "admin";
        public string UserPWD { get; private set; } = "user";

        public event EventHandler AdminLogged;
        public event EventHandler UserLogged;

        public LoginTransparent()
        {
            InitializeComponent();
        }

        public void LoadConfiguration()
        {

            Configuration cfg = new Configuration();

            HeaderBox.Text = cfg.Get("LoginHeaderText", HeaderBox.Text);
            HeaderBox.Font = cfg.GetFont("LoginHeaderFont", HeaderBox.Font);
            HeaderBox.ForeColor = cfg.GetColor("LoginHeaderForeColor", HeaderBox.ForeColor);
            HeaderBox.BackColor = cfg.GetColor("LoginHeaderBackColor", HeaderBox.BackColor);

            PwdBox.PasswordChar = cfg.Get("LoginPwdChar", PwdBox.PasswordChar.ToString())[0];
            PwdBox.Font = cfg.GetFont("LoginPwdFont", PwdBox.Font);
            PwdBox.ForeColor = cfg.GetColor("LoginPwdForeColor", PwdBox.ForeColor);
            PwdBox.BackColor = cfg.GetColor("LoginPwdBackColor", PwdBox.BackColor);

            AdminPWD = cfg.Get("LoginPwd", AdminPWD);
            UserPWD = cfg.Get("UserPwd", UserPWD);
        }

        private void PwdBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginRequest();
            }
        }

        private void LoginRequest()
        {
            string pwd = PwdBox.Text;

            if (pwd == AdminPWD)
                OnAdminAccess();

            if (pwd == UserPWD)
                OnUserAccess();
        }

        public void OnUserAccess()
        {
            PwdBox.Text = "";
            SearchToolWindow win = new SearchToolWindow();
            win.ShowDialog();
        }

        public void OnAdminAccess()
        {
            if (AdminLogged != null)
                AdminLogged(this, new EventArgs());

            PwdBox.Text = "";

        }

        private void LoginTransparent_Load(object sender, EventArgs e)
        {
            if(File.Exists(Configuration.Filepath))
            LoadConfiguration();
        }
    }
}
