namespace Individual_Coursework
{
    partial class Edit_entries
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.TXT_GENDER = new System.Windows.Forms.TextBox();
            this.LBL_GENDER = new System.Windows.Forms.Label();
            this.TXT_DOE = new System.Windows.Forms.TextBox();
            this.LBL_DOE = new System.Windows.Forms.Label();
            this.TXT_SEC_NAME = new System.Windows.Forms.TextBox();
            this.TXT_FIRST_NAME = new System.Windows.Forms.TextBox();
            this.TXT_FAM_NAME = new System.Windows.Forms.TextBox();
            this.LBL_FIRST_NAME = new System.Windows.Forms.Label();
            this.LBL_SEC_NAME = new System.Windows.Forms.Label();
            this.LBL_FAM_NAME = new System.Windows.Forms.Label();
            this.BTN_FILE = new System.Windows.Forms.Button();
            this.BTN_BACK = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TXT_FILE_LOC = new System.Windows.Forms.TextBox();
            this.LBL_SAVE_LOC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 34);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(554, 264);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Location = new System.Drawing.Point(596, 262);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(176, 36);
            this.BTN_SAVE.TabIndex = 1;
            this.BTN_SAVE.Text = "Save Changes";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.Edit_entries_Click);
            // 
            // TXT_GENDER
            // 
            this.TXT_GENDER.Location = new System.Drawing.Point(599, 234);
            this.TXT_GENDER.Name = "TXT_GENDER";
            this.TXT_GENDER.Size = new System.Drawing.Size(173, 22);
            this.TXT_GENDER.TabIndex = 28;
            // 
            // LBL_GENDER
            // 
            this.LBL_GENDER.AutoSize = true;
            this.LBL_GENDER.Location = new System.Drawing.Point(596, 214);
            this.LBL_GENDER.Name = "LBL_GENDER";
            this.LBL_GENDER.Size = new System.Drawing.Size(101, 17);
            this.LBL_GENDER.TabIndex = 27;
            this.LBL_GENDER.Text = "Gender (M/F) :";
            // 
            // TXT_DOE
            // 
            this.TXT_DOE.Location = new System.Drawing.Point(599, 189);
            this.TXT_DOE.Name = "TXT_DOE";
            this.TXT_DOE.Size = new System.Drawing.Size(173, 22);
            this.TXT_DOE.TabIndex = 26;
            // 
            // LBL_DOE
            // 
            this.LBL_DOE.AutoSize = true;
            this.LBL_DOE.Location = new System.Drawing.Point(596, 169);
            this.LBL_DOE.Name = "LBL_DOE";
            this.LBL_DOE.Size = new System.Drawing.Size(130, 17);
            this.LBL_DOE.TabIndex = 25;
            this.LBL_DOE.Text = "Date of Enrolment :";
            // 
            // TXT_SEC_NAME
            // 
            this.TXT_SEC_NAME.Location = new System.Drawing.Point(599, 144);
            this.TXT_SEC_NAME.Name = "TXT_SEC_NAME";
            this.TXT_SEC_NAME.Size = new System.Drawing.Size(173, 22);
            this.TXT_SEC_NAME.TabIndex = 24;
            // 
            // TXT_FIRST_NAME
            // 
            this.TXT_FIRST_NAME.Location = new System.Drawing.Point(599, 99);
            this.TXT_FIRST_NAME.Name = "TXT_FIRST_NAME";
            this.TXT_FIRST_NAME.Size = new System.Drawing.Size(173, 22);
            this.TXT_FIRST_NAME.TabIndex = 23;
            // 
            // TXT_FAM_NAME
            // 
            this.TXT_FAM_NAME.Location = new System.Drawing.Point(599, 54);
            this.TXT_FAM_NAME.Name = "TXT_FAM_NAME";
            this.TXT_FAM_NAME.Size = new System.Drawing.Size(173, 22);
            this.TXT_FAM_NAME.TabIndex = 22;
            // 
            // LBL_FIRST_NAME
            // 
            this.LBL_FIRST_NAME.AutoSize = true;
            this.LBL_FIRST_NAME.Location = new System.Drawing.Point(596, 79);
            this.LBL_FIRST_NAME.Name = "LBL_FIRST_NAME";
            this.LBL_FIRST_NAME.Size = new System.Drawing.Size(84, 17);
            this.LBL_FIRST_NAME.TabIndex = 21;
            this.LBL_FIRST_NAME.Text = "First Name :";
            // 
            // LBL_SEC_NAME
            // 
            this.LBL_SEC_NAME.AutoSize = true;
            this.LBL_SEC_NAME.Location = new System.Drawing.Point(596, 124);
            this.LBL_SEC_NAME.Name = "LBL_SEC_NAME";
            this.LBL_SEC_NAME.Size = new System.Drawing.Size(105, 17);
            this.LBL_SEC_NAME.TabIndex = 20;
            this.LBL_SEC_NAME.Text = "Second Name :";
            // 
            // LBL_FAM_NAME
            // 
            this.LBL_FAM_NAME.AutoSize = true;
            this.LBL_FAM_NAME.Location = new System.Drawing.Point(596, 34);
            this.LBL_FAM_NAME.Name = "LBL_FAM_NAME";
            this.LBL_FAM_NAME.Size = new System.Drawing.Size(97, 17);
            this.LBL_FAM_NAME.TabIndex = 19;
            this.LBL_FAM_NAME.Text = "Family Name :";
            // 
            // BTN_FILE
            // 
            this.BTN_FILE.Location = new System.Drawing.Point(595, 322);
            this.BTN_FILE.Name = "BTN_FILE";
            this.BTN_FILE.Size = new System.Drawing.Size(177, 38);
            this.BTN_FILE.TabIndex = 29;
            this.BTN_FILE.Text = "Save list to file";
            this.BTN_FILE.UseVisualStyleBackColor = true;
            this.BTN_FILE.Visible = false;
            this.BTN_FILE.Click += new System.EventHandler(this.BTN_FILE_Click);
            // 
            // BTN_BACK
            // 
            this.BTN_BACK.Location = new System.Drawing.Point(698, 12);
            this.BTN_BACK.Name = "BTN_BACK";
            this.BTN_BACK.Size = new System.Drawing.Size(74, 28);
            this.BTN_BACK.TabIndex = 30;
            this.BTN_BACK.Text = "Back";
            this.BTN_BACK.UseVisualStyleBackColor = true;
            this.BTN_BACK.Click += new System.EventHandler(this.BTN_BACK_Click);
            // 
            // TXT_FILE_LOC
            // 
            this.TXT_FILE_LOC.Location = new System.Drawing.Point(175, 304);
            this.TXT_FILE_LOC.Multiline = true;
            this.TXT_FILE_LOC.Name = "TXT_FILE_LOC";
            this.TXT_FILE_LOC.ReadOnly = true;
            this.TXT_FILE_LOC.Size = new System.Drawing.Size(414, 57);
            this.TXT_FILE_LOC.TabIndex = 31;
            // 
            // LBL_SAVE_LOC
            // 
            this.LBL_SAVE_LOC.AutoSize = true;
            this.LBL_SAVE_LOC.Location = new System.Drawing.Point(40, 307);
            this.LBL_SAVE_LOC.Name = "LBL_SAVE_LOC";
            this.LBL_SAVE_LOC.Size = new System.Drawing.Size(133, 17);
            this.LBL_SAVE_LOC.TabIndex = 32;
            this.LBL_SAVE_LOC.Text = "Currently Saved at :";
            this.LBL_SAVE_LOC.Click += new System.EventHandler(this.label1_Click);
            // 
            // Edit_entries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 373);
            this.Controls.Add(this.LBL_SAVE_LOC);
            this.Controls.Add(this.TXT_FILE_LOC);
            this.Controls.Add(this.BTN_BACK);
            this.Controls.Add(this.BTN_FILE);
            this.Controls.Add(this.TXT_GENDER);
            this.Controls.Add(this.LBL_GENDER);
            this.Controls.Add(this.TXT_DOE);
            this.Controls.Add(this.LBL_DOE);
            this.Controls.Add(this.TXT_SEC_NAME);
            this.Controls.Add(this.TXT_FIRST_NAME);
            this.Controls.Add(this.TXT_FAM_NAME);
            this.Controls.Add(this.LBL_FIRST_NAME);
            this.Controls.Add(this.LBL_SEC_NAME);
            this.Controls.Add(this.LBL_FAM_NAME);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.listView1);
            this.KeyPreview = true;
            this.Name = "Edit_entries";
            this.Text = "Edit entries";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Edit_entries_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.TextBox TXT_GENDER;
        private System.Windows.Forms.Label LBL_GENDER;
        private System.Windows.Forms.TextBox TXT_DOE;
        private System.Windows.Forms.Label LBL_DOE;
        private System.Windows.Forms.TextBox TXT_SEC_NAME;
        private System.Windows.Forms.TextBox TXT_FIRST_NAME;
        private System.Windows.Forms.TextBox TXT_FAM_NAME;
        private System.Windows.Forms.Label LBL_FIRST_NAME;
        private System.Windows.Forms.Label LBL_SEC_NAME;
        private System.Windows.Forms.Label LBL_FAM_NAME;
        private System.Windows.Forms.Button BTN_FILE;
        private System.Windows.Forms.Button BTN_BACK;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox TXT_FILE_LOC;
        private System.Windows.Forms.Label LBL_SAVE_LOC;
    }
}