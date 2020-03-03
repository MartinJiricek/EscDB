using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;


namespace EscapeDB
{
    public class Configuration
    {
        public static string Filepath { get { return Directory.GetCurrentDirectory() + $@"\configuration.ini"; } }

        private FontConverter _fcv = new FontConverter();
        private Font _dbgFont = new Font("Consolas", 8, FontStyle.Regular);

        private Dictionary<string, string> _data = new Dictionary<string, string>();

        public Color GeneralBackColor { get { return GetColor("GeneralBackColor", Color.Black); } }
        public Color EdgeBackColor { get { return GetColor("EdgeBackColor", Color.FromArgb(32, 32, 32)); ; } }


        public Color GeneralButtonForeColor { get { return GetColor("GeneralButtonForeColor", Color.Lime); } }
        public Color GeneralButtonBackColor { get { return GetColor("GeneralButtonBackColor", Color.Black); } }
        public Font GeneralButtonFont { get { return GetFont("GeneralButtonFont", new Font("Consolas", 9, FontStyle.Bold)); } }

        public Color GeneralContentForeColor { get { return GetColor("GeneralContentForeColor", Color.WhiteSmoke); } }
        public Color GeneralContentBackColor { get { return GetColor("GeneralContentBackColor", Color.FromArgb(112,32,32,32)); } }
        public Font GeneralContentFont { get { return GetFont("GeneralContentFont", new Font("Consolas", 8, FontStyle.Regular)); } }


        public Color DBHeaderForeColor { get { return GetColor("DBHeaderForeColor", Color.Lime); } }
        public Color DBHeaderBackColor { get { return GetColor("DBHeaderBackColor", Color.Black); } }
        public Font DBHeaderFont { get { return GetFont("DBHeaderFont", new Font("Consolas", 9, FontStyle.Bold)); } }


        public Color DBRecordForeColor { get { return GetColor("DBRecordForeColor", Color.Lime); } }
        public Color DBRecordBackColor { get { return GetColor("DBRecordBackColor", Color.Black); } }
        public Font DBRecordFont { get { return GetFont("DBRecordFont", new Font("Consolas", 8, FontStyle.Regular)); } }


        public Color LoginHeaderForeColor { get { return GetColor("LoginHeaderForeColor", Color.Lime); } }
        public Color LoginHeaderBackColor { get { return GetColor("LoginHeaderBackColor", Color.Black); } }
        public Font LoginHeaderFont { get { return GetFont("LoginHeaderFont", new Font("Consolas", 8, FontStyle.Bold)); } }


        public Color LoginTextForeColor { get { return GetColor("LoginTextForeColor", Color.Black); } }
        public Color LoginTextBackColor { get { return GetColor("LoginTextBackColor", Color.WhiteSmoke); } }
        public Font LoginTextFont { get { return GetFont("LoginTextFont", new Font("Consolas", 8, FontStyle.Bold)); } }
        public char LoginTextPwdChar { get { return Get("LoginTextPwdChar", "*")[0]; } }


        public Configuration()
        {
            _data = new Dictionary<string, string>();

            if(File.Exists(Filepath))
            LoadDataLines();

        }

        public  void LoadDataLines()
        {
            LoadDataLines(Filepath);
        }

        public void LoadDataLines(string filepath)
        {
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (line.Contains("]="))
                    {
                        int ix = line.IndexOf("]=");
                        string name = line.Substring(1, ix - 1);
                        string value = line.Replace($"[{name}]=", "");

                        _data.Add(name, value);
                    }
                }
            }
        }

        public void SaveDataLines()
        {
            DateTime now = DateTime.Now;
            List<string> lines = new List<string>();
            lines.Add($"Saved [{now.Year} {now.Month}.{now.Day}. - {now.Hour}:{now.Minute}:{now.Second}]");
            for (int i = 0; i < _data.Count; i ++)
            {
                string name = _data.Keys.ElementAt(i);
                string value = _data[name];

                lines.Add($"[{name}]={value}");
            }



            File.WriteAllLines(Filepath, lines.ToArray());
        }

        public void Add(string name, string value)
        {
            if (_data.ContainsKey(name))
                _data[name] = value;
            else
                _data.Add(name, value);

            SaveDataLines();
        }

        public bool ContainsKey(string propertyName)
        {
            return _data.ContainsKey(propertyName);
        }

        public string Get(string key)
        {
            if (ContainsKey(key))
            {
                return _data[key];
            }
            else
                return string.Empty;
        }

        public string Get(string key, string defaultValue)
        {
            if (ContainsKey(key))
                return _data[key];
            else
            {
                Add(key, defaultValue);
                return defaultValue;
            }
        }

        public Color GetColor(string colorName)
        {
            try
            {
                return ColorTranslator.FromHtml(_data[colorName]);
            }
            catch { } // returns empty color
            return Color.Black;
        }
        public Color GetColor(string colorName, Color defaultColor)
        {
            if(ContainsKey(colorName))
                return ColorTranslator.FromHtml(_data[colorName]);
            else
            {
                Add(defaultColor, colorName);
                return defaultColor;
            }
        }

        public void Add(Color color, string colorName)
        {
            string value = ColorTranslator.ToHtml(color);
            Add(colorName, value);
        }

        public Font GetFont(string fontName)
        {
            if (ContainsKey(fontName))
            {
                return _fcv.ConvertFromString(_data[fontName]) as Font;
            }
            else
            {
                return _dbgFont;
            }
        }

        public Font GetFont(string fontName, Font font)
        {
            if (ContainsKey(fontName))
            {
                return _fcv.ConvertFromString(_data[fontName]) as Font;
            }
            else
            {
                Add(fontName,_fcv.ConvertToString(font));
                return font;
            }
        }

        public int GetInteger(string intName)
        {
            if (ContainsKey(intName))
            {
                return int.Parse(_data[intName]);
            }
            else
            {
                return 0;
            }
        }
        public void Add(int value, string intName)
        {
            Add(intName, value.ToString());
        }
        public int GetInteger(string intName, int value)
        {
            if (ContainsKey(intName))
            {
                return int.Parse(_data[intName]);
            }
            else
            {
                Add(value, intName);
                return value;
            }
        }







    }
}
