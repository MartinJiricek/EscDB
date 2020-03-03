using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EscapeDB
{
    public partial class SearchControl : UIControlBase
    {
        public Dictionary<string, PersonalData> Database { get; set; }

        public SearchControl()
        {
            InitializeComponent();
            Database = new Dictionary<string, PersonalData>();
            Test();
        }

        public void Test()
        {

            foreach (PersonalData person in PersonalDataManager.GetAvailablePersons())
                AddPerson(person);
        }

        public void LoadConfiguration()
        {
            Configuration cfg = new Configuration();

            PersonList.GridColor = cfg.DBHeaderForeColor;
            PersonList.ColumnHeadersDefaultCellStyle.ForeColor = cfg.DBHeaderForeColor;
            PersonList.ColumnHeadersDefaultCellStyle.ForeColor = cfg.DBHeaderForeColor;
            PersonList.ColumnHeadersDefaultCellStyle.Font = cfg.DBHeaderFont;

            PersonList.DefaultCellStyle.ForeColor = cfg.DBRecordForeColor;
            PersonList.DefaultCellStyle.BackColor = cfg.DBRecordBackColor;
            PersonList.DefaultCellStyle.Font = cfg.DBRecordFont;

            label1.Font = cfg.GeneralContentFont;
            label1.ForeColor = cfg.GeneralContentForeColor;
            label1.BackColor = cfg.GeneralContentBackColor;

            SearchBox.BackColor = cfg.GeneralContentBackColor;
            SearchBox.ForeColor = cfg.GeneralContentForeColor;
            SearchBox.Font = cfg.GeneralContentFont;


        }

        public void LoadPerson(PersonalData personData)
        {
            PersonBox.LoadPerson(personData);
        }

        public void AddPerson(PersonalData personData)
        {
            if (personData == null)
                return;

            if (Database == null)
                Database = new Dictionary<string, PersonalData>();

            if (Database.ContainsKey(personData.Name))
                return;
            Database.Add(personData.Name, personData);
        }

        public void ShowNameMatches(string searchText)
        {
            PersonList.Rows.Clear();

            for (int i = 0; i < Database.Count; i++)

            {
                string name = Database.Keys.ToList()[i];
                if (name.ToLower().Contains(searchText.ToLower()))
                {
                    ShowMatchedPerson(Database[name]);
                }
            }
        }

        public void ShowMatchedPerson(PersonalData personalData)
        {
            PersonList.Rows.Add(personalData.Name, personalData.Age, personalData.Sex, personalData.Job);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text.Length > 2)
            {
                ShowNameMatches(SearchBox.Text);
            }
            else
                PersonList.Rows.Clear();
        }

        private void PersonList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void PersonList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int r = e.RowIndex;
                int c = e.ColumnIndex;

                if (r < 0 | r >= PersonList.RowCount | c < 0 | c >= PersonList.ColumnCount)
                    return;

                string name = PersonList[c, r].Value.ToString();

                if (Database.ContainsKey(name))
                    LoadPerson(Database[name]);
            }
            catch { }
        }

        private void SearchBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (SearchBox.Text == "Enter text to search. . .")
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = Color.White;
            }
        }

        private void PersonList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PersonList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);
            }
            catch { }

        }

        private void PersonList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PersonList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0,0,0);
            }
            catch { }

        }

        private void PersonList_SelectionChanged(object sender, EventArgs e)
        {
            PersonList.ClearSelection();
        }
    }
}