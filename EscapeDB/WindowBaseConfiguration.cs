using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Drawing;

namespace EscapeDB
{
    public partial class WindowBase
    {
        // Color Definitions
        #region
        public Color CloserInActive { get; private set; } = Color.FromArgb(32, 0, 0);
        public Color CloserActive { get; private set; } = Color.FromArgb(255, 0, 0);
        public Color ResizerInActive { get; private set; } = Color.FromArgb(32, 32, 0);
        public Color ResizerActive { get; private set; } = Color.FromArgb(255, 255, 0);
        #endregion



        public void LoadConfiguration()
        {
            if (File.Exists(Configuration.Filepath))
                ConfigureColors();
        }

        public void ConfigureColors()
        {
            CloserInActive = Config.GetColor("CloserInActive", CloserInActive);
            ResizerInActive = Config.GetColor("ResizerInActive", ResizerInActive);
            CloserActive = Config.GetColor("CloserActive", CloserActive);
            ResizerActive = Config.GetColor("ResizerActive", ResizerActive);

            Closer.BackColor = CloserInActive;
            Resizer.BackColor = ResizerInActive;


            BackColor = Config.GeneralBackColor;
            TopPanel.BackColor = Config.GeneralContentBackColor;
            LeftPanel.BackColor = Config.GeneralContentBackColor;
            BottomPanel.BackColor = Config.GeneralContentBackColor;
            RightPanel.BackColor = Config.GeneralContentBackColor;

            Header.Font = Config.GeneralContentFont;
            Header.ForeColor = Config.GeneralContentForeColor;
        }

    }
}
