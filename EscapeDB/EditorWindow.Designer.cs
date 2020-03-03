namespace EscapeDB
{
    partial class EditorWindow
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
            this.personalDataEditor1 = new EscapeDB.PersonalDataEditor();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(15, 722);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(728, 22);
            this.RightPanel.Size = new System.Drawing.Size(15, 722);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(738, 17);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Location = new System.Drawing.Point(5, 744);
            this.BottomPanel.Size = new System.Drawing.Size(738, 15);
            // 
            // Resizer
            // 
            this.Resizer.Location = new System.Drawing.Point(723, 0);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(723, 17);
            this.Header.Text = "Personal data editor";
            // 
            // Closer
            // 
            this.Closer.Location = new System.Drawing.Point(723, 0);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.personalDataEditor1);
            this.MainPanel.Size = new System.Drawing.Size(708, 722);
            // 
            // BottomBorder
            // 
            this.BottomBorder.Location = new System.Drawing.Point(5, 759);
            this.BottomBorder.Size = new System.Drawing.Size(738, 5);
            // 
            // RightBorder
            // 
            this.RightBorder.Location = new System.Drawing.Point(743, 5);
            this.RightBorder.Size = new System.Drawing.Size(5, 759);
            // 
            // LeftBorder
            // 
            this.LeftBorder.Size = new System.Drawing.Size(5, 759);
            // 
            // TopBorder
            // 
            this.TopBorder.Size = new System.Drawing.Size(748, 5);
            // 
            // personalDataEditor1
            // 
            this.personalDataEditor1.BackColor = System.Drawing.Color.Black;
            this.personalDataEditor1.Data = null;
            this.personalDataEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalDataEditor1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalDataEditor1.ForeColor = System.Drawing.Color.Lime;
            this.personalDataEditor1.Location = new System.Drawing.Point(0, 0);
            this.personalDataEditor1.Name = "personalDataEditor1";
            this.personalDataEditor1.Size = new System.Drawing.Size(708, 722);
            this.personalDataEditor1.TabIndex = 0;
            this.personalDataEditor1.Load += new System.EventHandler(this.personalDataEditor1_Load);
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 764);
            this.Name = "EditorWindow";
            this.Text = "EditorWindow";
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonalDataEditor personalDataEditor1;
    }
}