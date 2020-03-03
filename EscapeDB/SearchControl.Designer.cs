namespace EscapeDB
{
    partial class SearchControl
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PersonList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PersonBox = new EscapeDB.PersonDataView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonList)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.Size = new System.Drawing.Size(911, 23);
            // 
            // LeftBorder
            // 
            this.LeftBorder.Size = new System.Drawing.Size(10, 605);
            // 
            // RightBorder
            // 
            this.RightBorder.Location = new System.Drawing.Point(901, 23);
            this.RightBorder.Size = new System.Drawing.Size(10, 605);
            // 
            // BottomBorder
            // 
            this.BottomBorder.Location = new System.Drawing.Point(0, 628);
            this.BottomBorder.Size = new System.Drawing.Size(911, 10);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 31);
            this.panel1.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchBox.Location = new System.Drawing.Point(110, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(325, 20);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchBox_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 0);
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vyhledávání:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 31);
            this.panel2.TabIndex = 5;
            // 
            // PersonList
            // 
            this.PersonList.BackgroundColor = System.Drawing.Color.Black;
            this.PersonList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PersonList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PersonList.ColumnHeadersHeight = 30;
            this.PersonList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonList.DefaultCellStyle = dataGridViewCellStyle2;
            this.PersonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonList.EnableHeadersVisualStyles = false;
            this.PersonList.GridColor = System.Drawing.Color.Lime;
            this.PersonList.Location = new System.Drawing.Point(0, 62);
            this.PersonList.Name = "PersonList";
            this.PersonList.ReadOnly = true;
            this.PersonList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PersonList.RowHeadersVisible = false;
            this.PersonList.Size = new System.Drawing.Size(435, 543);
            this.PersonList.TabIndex = 6;
            this.PersonList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PersonList_CellMouseDoubleClick);
            this.PersonList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonList_CellMouseEnter);
            this.PersonList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonList_CellMouseLeave);
            this.PersonList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PersonList_CellMouseMove);
            this.PersonList.SelectionChanged += new System.EventHandler(this.PersonList_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Jméno";
            this.Column1.MinimumWidth = 120;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Věk";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 49;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Pohlaví";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 73;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 23);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PersonList);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PersonBox);
            this.splitContainer1.Size = new System.Drawing.Size(891, 605);
            this.splitContainer1.SplitterDistance = 435;
            this.splitContainer1.TabIndex = 7;
            // 
            // PersonBox
            // 
            this.PersonBox.BackColor = System.Drawing.Color.Black;
            this.PersonBox.Data = null;
            this.PersonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonBox.ForeColor = System.Drawing.Color.Lime;
            this.PersonBox.Location = new System.Drawing.Point(0, 0);
            this.PersonBox.Name = "PersonBox";
            this.PersonBox.Size = new System.Drawing.Size(452, 605);
            this.PersonBox.TabIndex = 0;
            this.PersonBox.Visible = false;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(911, 638);
            this.Controls.SetChildIndex(this.BottomBorder, 0);
            this.Controls.SetChildIndex(this.TopBorder, 0);
            this.Controls.SetChildIndex(this.LeftBorder, 0);
            this.Controls.SetChildIndex(this.RightBorder, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonList)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView PersonList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private PersonDataView PersonBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
