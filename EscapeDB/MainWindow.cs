using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;
using System.Reflection;

namespace EscapeDB
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            CenterLoginBox();
        }

        private void CenterLoginBox()
        {

            int x = Screen.FromControl(this).Bounds.Width / 2 - (LoginBox.Width / 2);
            int y = Screen.FromControl(this).Bounds.Height / 2 - (LoginBox.Height / 2);

            LoginBox.Location = new System.Drawing.Point(x, y);
            LoginBox.AdminLogged += LoginBox_AdminLogged;
        }

        private void LoginBox_AdminLogged(object sender, EventArgs e)
        {
            CloseBtn.Visible = true;
            SearchBtn.Visible = true;
            EditorBtn.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchToolWindow win = new SearchToolWindow();
            win.ShowDialog();
        }

        private void EditorBtn_Click(object sender, EventArgs e)
        {
            EditorWindow win = new EditorWindow();
            win.ShowDialog();
        }

        public void LoadBackground(string filepath)
        {

        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {

        }
        /* Code to Disable WinKey, Alt+Tab, Ctrl+Esc Starts Here */

        // Structure contain information about low-level keyboard input event
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }
        //System level functions to be used for hook and unhook keyboard input
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        //Declaring Global objects
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Disabling Windows keys

                if (objKeyInfo.key == Keys.F4
                    || objKeyInfo.key == Keys.RWin
                    || objKeyInfo.key == Keys.LWin
                    || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags)
                    || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control
                    || objKeyInfo.key == Keys.Delete &&  HasAltModifier(objKeyInfo.flags) && (ModifierKeys & Keys.Control) == Keys.Control
                    || ((objKeyInfo.flags & 32) == 32) && ((objKeyInfo.flags & 16) == 16))
                {
                    return (IntPtr)1; // if 0 is returned then All the above keys will be enabled
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);

        }

        /* Code to Disable WinKey, Alt+Tab, Ctrl+Esc Ends Here */

        private void DisableCtrl()
        {
            const string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Keyboard Layout";
            try
            {
                Registry.SetValue(keyName, "Scancode Map", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0x3, 0, 0, 0,
                    0, 0, 0x1d, 0, 0, 0, 0x1d, 0xe0, 0, 0, 0, 0 }, RegistryValueKind.Binary);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            MessageBox.Show("Ctrl key is disabled!\nRestart computer to take effect!");
        }

        private void EnableCtrl()
        {
            RegistryKey rkLm = Registry.LocalMachine;
            RegistryKey rkLmSys = rkLm.OpenSubKey("SYSTEM");
            RegistryKey rkLmSysCcs = rkLmSys.OpenSubKey("CurrentControlSet");
            RegistryKey rkLmSysCcsCtrl = rkLmSysCcs.OpenSubKey("Control");
            RegistryKey rkLmSysCCsCtrlKl = rkLmSysCcsCtrl.OpenSubKey("Keyboard Layout", true);
            try
            {
                rkLmSysCCsCtrlKl.DeleteValue("Scancode Map", true);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "\n" + "Ctrl key has been enabled!\nYou don't need to enable it again.");
                return;
            }
            MessageBox.Show("Ctrl key is enabled!\nRestart computer to take effect!");
            rkLmSysCCsCtrlKl.Close();

        }


    }
}