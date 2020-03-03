using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EscapeDB
{
    public partial class LoadingBarDialog : WindowBase
    {
        public int Speed { get; set; } = 100;
        private Timer _timer = new Timer();
        private int _value = 0;

        public LoadingBarDialog()
        {
            InitializeComponent();
            Bar.BackColor = Color.Black;
            Bar.ForeColor = Color.Lime;
            Bar.Minimum = 0;
            Bar.Maximum = 100;
            Bar.Value = 0;

            _timer.Interval = Speed;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {

            if (_value >= Bar.Maximum)
            {
                _timer.Stop();
                Close();
            }

                Bar.Value = _value;

            AddValue();
        }

        public void LoadConfiguration()
        {
            Configuration cgf = new Configuration();
        }

        public void AddValue(int val = 1)
        {
            _value = Bar.Value + val;
        }
    }
}
