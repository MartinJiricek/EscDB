using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EscapeDB
{
    public partial class WindowBase : Form
    {
        private bool _resizing = false;
        private Point _lastLocation = new Point(0, 0);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Configuration Config { get; private set; } = new Configuration();

        public WindowBase()
        {
            InitializeComponent();
            Closer.BackColor = CloserInActive;
            Resizer.BackColor = ResizerInActive;

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            LoadConfiguration();
        }

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }


        private void Closer_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
        }

        private void Closer_MouseEnter(object sender, EventArgs e)
        {
            Closer.BackColor = CloserActive;
        }

        private void Closer_MouseLeave(object sender, EventArgs e)
        {
            Closer.BackColor = CloserInActive;
        }

        private void Resizer_MouseDown(object sender, MouseEventArgs e)
        {
            _resizing = true;
        }

        private void Resizer_MouseUp(object sender, MouseEventArgs e)
        {
            _resizing = false;
        }

        private void Resizer_MouseEnter(object sender, EventArgs e)
        {
            Resizer.BackColor = ResizerActive;
        }

        private void Resizer_MouseLeave(object sender, EventArgs e)
        {
            Resizer.BackColor = ResizerInActive;
        }

        private void Resizer_MouseMove(object sender, MouseEventArgs e)
        {
            if (_resizing)
            {
                this.Size = new Size(Cursor.Position.X - this.Location.X,
                                     Cursor.Position.Y - this.Location.Y);
            }
        }

        private void MouseDownMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }


    }
}