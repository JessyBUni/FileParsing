namespace Individual_Coursework
{
    partial class Main_interface
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
            this.LBL_FILE_LOC = new System.Windows.Forms.Label();
            this.TXT_FILE_LOC = new System.Windows.Forms.Label();
            this.BTN_OPEN_FILE = new System.Windows.Forms.Button();
            this.LBL_ENTRY = new System.Windows.Forms.Label();
            this.LBL_ENTRY_ED = new System.Windows.Forms.Label();
            this.BTN_FIRST_ENTRY = new System.Windows.Forms.Button();
            this.BTN_PREV_ENTRY = new System.Windows.Forms.Button();
            this.BTN_LAST_ENTRY = new System.Windows.Forms.Button();
            this.BTN_NEXT_ENTRY = new System.Windows.Forms.Button();
            this.LBL_FAM_NAME = new System.Windows.Forms.Label();
            this.LBL_SEC_NAME = new System.Windows.Forms.Label();
            this.LBL_FIRST_NAME = new System.Windows.Forms.Label();
            this.TXT_FAM_NAME = new System.Windows.Forms.TextBox();
            this.TXT_FIRST_NAME = new System.Windows.Forms.TextBox();
            this.TXT_SEC_NAME = new System.Windows.Forms.TextBox();
            this.TXT_DOE = new System.Windows.Forms.TextBox();
            this.LBL_DOE = new System.Windows.Forms.Label();
            this.TXT_GENDER = new System.Windows.Forms.TextBox();
            this.LBL_GENDER = new System.Windows.Forms.Label();
            this.CB_SORT = new System.Windows.Forms.ComboBox();
            this.LBL_SORT = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BTN_TIME = new System.Windows.Forms.Button();
            this.TXT_TIME = new System.Windows.Forms.TextBox();
            this.RB_YEAR = new System.Windows.Forms.RadioButton();
            this.RB_MONTH = new System.Windows.Forms.RadioButton();
            this.RB_DAY = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_FILE_LOC
            // 
            this.LBL_FILE_LOC.AutoSize = true;
            this.LBL_FILE_LOC.Location = new System.Drawing.Point(12, 19);
            this.LBL_FILE_LOC.Name = "LBL_FILE_LOC";
            this.LBL_FILE_LOC.Size = new System.Drawing.Size(91, 17);
            this.LBL_FILE_LOC.TabIndex = 0;
            this.LBL_FILE_LOC.Text = "File location :";
            // 
            // TXT_FILE_LOC
            // 
            this.TXT_FILE_LOC.AllowDrop = true;
            this.TXT_FILE_LOC.Location = new System.Drawing.Point(109, 19);
            this.TXT_FILE_LOC.Name = "TXT_FILE_LOC";
            this.TXT_FILE_LOC.Size = new System.Drawing.Size(314, 92);
            this.TXT_FILE_LOC.TabIndex = 1;
            this.TXT_FILE_LOC.Text = "No file loaded";
            // 
            // BTN_OPEN_FILE
            // 
            this.BTN_OPEN_FILE.Location = new System.Drawing.Point(439, 19);
            this.BTN_OPEN_FILE.Name = "BTN_OPEN_FILE";
            this.BTN_OPEN_FILE.Size = new System.Drawing.Size(89, 31);
            this.BTN_OPEN_FILE.TabIndex = 2;
            this.BTN_OPEN_FILE.Text = "Open";
            this.BTN_OPEN_FILE.UseVisualStyleBackColor = true;
            this.BTN_OPEN_FILE.Click += new System.EventHandler(this.BTN_OPEN_FILE_Click);
            // 
            // LBL_ENTRY
            // 
            this.LBL_ENTRY.AutoSize = true;
            this.LBL_ENTRY.Location = new System.Drawing.Point(13, 106);
            this.LBL_ENTRY.Name = "LBL_ENTRY";
            this.LBL_ENTRY.Size = new System.Drawing.Size(41, 17);
            this.LBL_ENTRY.TabIndex = 3;
            this.LBL_ENTRY.Text = "Entry";
            // 
            // LBL_ENTRY_ED
            // 
            this.LBL_ENTRY_ED.AutoSize = true;
            this.LBL_ENTRY_ED.Location = new System.Drawing.Point(63, 106);
            this.LBL_ENTRY_ED.Name = "LBL_ENTRY_ED";
            this.LBL_ENTRY_ED.Size = new System.Drawing.Size(36, 17);
            this.LBL_ENTRY_ED.TabIndex = 4;
            this.LBL_ENTRY_ED.Text = "0 / 0";
            // 
            // BTN_FIRST_ENTRY
            // 
            this.BTN_FIRST_ENTRY.Enabled = false;
            this.BTN_FIRST_ENTRY.Location = new System.Drawing.Point(13, 136);
            this.BTN_FIRST_ENTRY.Name = "BTN_FIRST_ENTRY";
            this.BTN_FIRST_ENTRY.Size = new System.Drawing.Size(109, 30);
            this.BTN_FIRST_ENTRY.TabIndex = 5;
            this.BTN_FIRST_ENTRY.Text = " First Entry";
            this.BTN_FIRST_ENTRY.UseVisualStyleBackColor = true;
            this.BTN_FIRST_ENTRY.Click += new System.EventHandler(this.BTN_FIRST_ENTRY_Click);
            // 
            // BTN_PREV_ENTRY
            // 
            this.BTN_PREV_ENTRY.Enabled = false;
            this.BTN_PREV_ENTRY.Location = new System.Drawing.Point(146, 136);
            this.BTN_PREV_ENTRY.Name = "BTN_PREV_ENTRY";
            this.BTN_PREV_ENTRY.Size = new System.Drawing.Size(109, 30);
            this.BTN_PREV_ENTRY.TabIndex = 6;
            this.BTN_PREV_ENTRY.Text = "Previous Entry";
            this.BTN_PREV_ENTRY.UseVisualStyleBackColor = true;
            this.BTN_PREV_ENTRY.Click += new System.EventHandler(this.BTN_PREV_ENTRY_Click);
            // 
            // BTN_LAST_ENTRY
            // 
            this.BTN_LAST_ENTRY.Enabled = false;
            this.BTN_LAST_ENTRY.Location = new System.Drawing.Point(419, 136);
            this.BTN_LAST_ENTRY.Name = "BTN_LAST_ENTRY";
            this.BTN_LAST_ENTRY.Size = new System.Drawing.Size(109, 30);
            this.BTN_LAST_ENTRY.TabIndex = 7;
            this.BTN_LAST_ENTRY.Text = "Last Entry";
            this.BTN_LAST_ENTRY.UseVisualStyleBackColor = true;
            this.BTN_LAST_ENTRY.Click += new System.EventHandler(this.BTN_LAST_ENTRY_Click);
            // 
            // BTN_NEXT_ENTRY
            // 
            this.BTN_NEXT_ENTRY.Enabled = false;
            this.BTN_NEXT_ENTRY.Location = new System.Drawing.Point(283, 136);
            this.BTN_NEXT_ENTRY.Name = "BTN_NEXT_ENTRY";
            this.BTN_NEXT_ENTRY.Size = new System.Drawing.Size(109, 30);
            this.BTN_NEXT_ENTRY.TabIndex = 8;
            this.BTN_NEXT_ENTRY.Text = "Next Entry";
            this.BTN_NEXT_ENTRY.UseVisualStyleBackColor = true;
            this.BTN_NEXT_ENTRY.Click += new System.EventHandler(this.BTN_NEXT_ENTRY_Click);
            // 
            // LBL_FAM_NAME
            // 
            this.LBL_FAM_NAME.AutoSize = true;
            this.LBL_FAM_NAME.Location = new System.Drawing.Point(43, 203);
            this.LBL_FAM_NAME.Name = "LBL_FAM_NAME";
            this.LBL_FAM_NAME.Size = new System.Drawing.Size(97, 17);
            this.LBL_FAM_NAME.TabIndex = 9;
            this.LBL_FAM_NAME.Text = "Family Name :";
            // 
            // LBL_SEC_NAME
            // 
            this.LBL_SEC_NAME.AutoSize = true;
            this.LBL_SEC_NAME.Location = new System.Drawing.Point(35, 259);
            this.LBL_SEC_NAME.Name = "LBL_SEC_NAME";
            this.LBL_SEC_NAME.Size = new System.Drawing.Size(105, 17);
            this.LBL_SEC_NAME.TabIndex = 10;
            this.LBL_SEC_NAME.Text = "Second Name :";
            // 
            // LBL_FIRST_NAME
            // 
            this.LBL_FIRST_NAME.AutoSize = true;
            this.LBL_FIRST_NAME.Location = new System.Drawing.Point(56, 231);
            this.LBL_FIRST_NAME.Name = "LBL_FIRST_NAME";
            this.LBL_FIRST_NAME.Size = new System.Drawing.Size(84, 17);
            this.LBL_FIRST_NAME.TabIndex = 11;
            this.LBL_FIRST_NAME.Text = "First Name :";
            // 
            // TXT_FAM_NAME
            // 
            this.TXT_FAM_NAME.Location = new System.Drawing.Point(146, 200);
            this.TXT_FAM_NAME.Name = "TXT_FAM_NAME";
            this.TXT_FAM_NAME.ReadOnly = true;
            this.TXT_FAM_NAME.Size = new System.Drawing.Size(173, 22);
            this.TXT_FAM_NAME.TabIndex = 12;
            // 
            // TXT_FIRST_NAME
            // 
            this.TXT_FIRST_NAME.Location = new System.Drawing.Point(146, 228);
            this.TXT_FIRST_NAME.Name = "TXT_FIRST_NAME";
            this.TXT_FIRST_NAME.ReadOnly = true;
            this.TXT_FIRST_NAME.Size = new System.Drawing.Size(173, 22);
            this.TXT_FIRST_NAME.TabIndex = 13;
            // 
            // TXT_SEC_NAME
            // 
            this.TXT_SEC_NAME.Location = new System.Drawing.Point(146, 256);
            this.TXT_SEC_NAME.Name = "TXT_SEC_NAME";
            this.TXT_SEC_NAME.ReadOnly = true;
            this.TXT_SEC_NAME.Size = new System.Drawing.Size(173, 22);
            this.TXT_SEC_NAME.TabIndex = 14;
            // 
            // TXT_DOE
            // 
            this.TXT_DOE.Location = new System.Drawing.Point(146, 284);
            this.TXT_DOE.Name = "TXT_DOE";
            this.TXT_DOE.ReadOnly = true;
            this.TXT_DOE.Size = new System.Drawing.Size(173, 22);
            this.TXT_DOE.TabIndex = 16;
            // 
            // LBL_DOE
            // 
            this.LBL_DOE.AutoSize = true;
            this.LBL_DOE.Location = new System.Drawing.Point(10, 287);
            this.LBL_DOE.Name = "LBL_DOE";
            this.LBL_DOE.Size = new System.Drawing.Size(130, 17);
            this.LBL_DOE.TabIndex = 15;
            this.LBL_DOE.Text = "Date of Enrolment :";
            // 
            // TXT_GENDER
            // 
            this.TXT_GENDER.Location = new System.Drawing.Point(146, 312);
            this.TXT_GENDER.Name = "TXT_GENDER";
            this.TXT_GENDER.ReadOnly = true;
            this.TXT_GENDER.Size = new System.Drawing.Size(173, 22);
            this.TXT_GENDER.TabIndex = 18;
            // 
            // LBL_GENDER
            // 
            this.LBL_GENDER.AutoSize = true;
            this.LBL_GENDER.Location = new System.Drawing.Point(39, 315);
            this.LBL_GENDER.Name = "LBL_GENDER";
            this.LBL_GENDER.Size = new System.Drawing.Size(101, 17);
            this.LBL_GENDER.TabIndex = 17;
            this.LBL_GENDER.Text = "Gender (M/F) :";
            // 
            // CB_SORT
            // 
            this.CB_SORT.Enabled = false;
            this.CB_SORT.FormattingEnabled = true;
            this.CB_SORT.Items.AddRange(new object[] {
            "No Sort ",
            "Family Name Sort"});
            this.CB_SORT.Location = new System.Drawing.Point(345, 200);
            this.CB_SORT.Name = "CB_SORT";
            this.CB_SORT.Size = new System.Drawing.Size(183, 24);
            this.CB_SORT.TabIndex = 19;
            this.CB_SORT.Text = "No Sort ";
            this.CB_SORT.SelectedIndexChanged += new System.EventHandler(this.CB_SORT_SelectedIndexChanged);
            // 
            // LBL_SORT
            // 
            this.LBL_SORT.AutoSize = true;
            this.LBL_SORT.Location = new System.Drawing.Point(342, 180);
            this.LBL_SORT.Name = "LBL_SORT";
            this.LBL_SORT.Size = new System.Drawing.Size(88, 17);
            this.LBL_SORT.TabIndex = 20;
            this.LBL_SORT.Text = "Sort Option :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BTN_TIME
            // 
            this.BTN_TIME.Enabled = false;
            this.BTN_TIME.Location = new System.Drawing.Point(345, 231);
            this.BTN_TIME.Name = "BTN_TIME";
            this.BTN_TIME.Size = new System.Drawing.Size(183, 33);
            this.BTN_TIME.TabIndex = 22;
            this.BTN_TIME.Text = "Calculate Time in System";
            this.BTN_TIME.UseVisualStyleBackColor = true;
            this.BTN_TIME.Click += new System.EventHandler(this.BTN_TIME_Click);
            // 
            // TXT_TIME
            // 
            this.TXT_TIME.Location = new System.Drawing.Point(347, 270);
            this.TXT_TIME.Name = "TXT_TIME";
            this.TXT_TIME.ReadOnly = true;
            this.TXT_TIME.Size = new System.Drawing.Size(181, 22);
            this.TXT_TIME.TabIndex = 23;
            // 
            // RB_YEAR
            // 
            this.RB_YEAR.AutoSize = true;
            this.RB_YEAR.Enabled = false;
            this.RB_YEAR.Location = new System.Drawing.Point(349, 298);
            this.RB_YEAR.Name = "RB_YEAR";
            this.RB_YEAR.Size = new System.Drawing.Size(81, 21);
            this.RB_YEAR.TabIndex = 24;
            this.RB_YEAR.Text = "In Years";
            this.RB_YEAR.UseVisualStyleBackColor = true;
            this.RB_YEAR.CheckedChanged += new System.EventHandler(this.RB_YEAR_CheckedChanged);
            // 
            // RB_MONTH
            // 
            this.RB_MONTH.AutoSize = true;
            this.RB_MONTH.Enabled = false;
            this.RB_MONTH.Location = new System.Drawing.Point(349, 319);
            this.RB_MONTH.Name = "RB_MONTH";
            this.RB_MONTH.Size = new System.Drawing.Size(90, 21);
            this.RB_MONTH.TabIndex = 25;
            this.RB_MONTH.Text = "In Months";
            this.RB_MONTH.UseVisualStyleBackColor = true;
            this.RB_MONTH.CheckedChanged += new System.EventHandler(this.RB_MONTH_CheckedChanged);
            // 
            // RB_DAY
            // 
            this.RB_DAY.AutoSize = true;
            this.RB_DAY.Checked = true;
            this.RB_DAY.Enabled = false;
            this.RB_DAY.Location = new System.Drawing.Point(349, 339);
            this.RB_DAY.Name = "RB_DAY";
            this.RB_DAY.Size = new System.Drawing.Size(76, 21);
            this.RB_DAY.TabIndex = 26;
            this.RB_DAY.TabStop = true;
            this.RB_DAY.Text = "In Days";
            this.RB_DAY.UseVisualStyleBackColor = true;
            this.RB_DAY.CheckedChanged += new System.EventHandler(this.RB_DAY_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(439, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 55);
            this.button1.TabIndex = 27;
            this.button1.Text = "Change Entries";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RB_DAY);
            this.Controls.Add(this.RB_MONTH);
            this.Controls.Add(this.RB_YEAR);
            this.Controls.Add(this.TXT_TIME);
            this.Controls.Add(this.BTN_TIME);
            this.Controls.Add(this.LBL_SORT);
            this.Controls.Add(this.CB_SORT);
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
            this.Controls.Add(this.BTN_NEXT_ENTRY);
            this.Controls.Add(this.BTN_LAST_ENTRY);
            this.Controls.Add(this.BTN_PREV_ENTRY);
            this.Controls.Add(this.BTN_FIRST_ENTRY);
            this.Controls.Add(this.LBL_ENTRY_ED);
            this.Controls.Add(this.LBL_ENTRY);
            this.Controls.Add(this.BTN_OPEN_FILE);
            this.Controls.Add(this.TXT_FILE_LOC);
            this.Controls.Add(this.LBL_FILE_LOC);
            this.KeyPreview = true;
            this.Name = "Main_interface";
            this.Text = "Person viewer program";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_interface_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_FILE_LOC;
        private System.Windows.Forms.Label TXT_FILE_LOC;
        private System.Windows.Forms.Button BTN_OPEN_FILE;
        private System.Windows.Forms.Label LBL_ENTRY;
        private System.Windows.Forms.Label LBL_ENTRY_ED;
        private System.Windows.Forms.Button BTN_FIRST_ENTRY;
        private System.Windows.Forms.Button BTN_PREV_ENTRY;
        private System.Windows.Forms.Button BTN_LAST_ENTRY;
        private System.Windows.Forms.Button BTN_NEXT_ENTRY;
        private System.Windows.Forms.Label LBL_FAM_NAME;
        private System.Windows.Forms.Label LBL_SEC_NAME;
        private System.Windows.Forms.Label LBL_FIRST_NAME;
        private System.Windows.Forms.TextBox TXT_FAM_NAME;
        private System.Windows.Forms.TextBox TXT_FIRST_NAME;
        private System.Windows.Forms.TextBox TXT_SEC_NAME;
        private System.Windows.Forms.TextBox TXT_DOE;
        private System.Windows.Forms.Label LBL_DOE;
        private System.Windows.Forms.TextBox TXT_GENDER;
        private System.Windows.Forms.Label LBL_GENDER;
        private System.Windows.Forms.ComboBox CB_SORT;
        private System.Windows.Forms.Label LBL_SORT;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BTN_TIME;
        private System.Windows.Forms.TextBox TXT_TIME;
        private System.Windows.Forms.RadioButton RB_YEAR;
        private System.Windows.Forms.RadioButton RB_MONTH;
        private System.Windows.Forms.RadioButton RB_DAY;
        private System.Windows.Forms.Button button1;
    }
}