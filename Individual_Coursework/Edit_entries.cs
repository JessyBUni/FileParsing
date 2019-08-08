using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Individual_Coursework
{
    public partial class Edit_entries : Form
    {
        public Edit_entries(List<Person> people, string old_save_loc)
        {
            InitializeComponent();

            listView1.View = View.Details;
            // set colum sizes
            listView1.Columns.Add("Family Name",80);
            listView1.Columns.Add("First Name",80);
            listView1.Columns.Add("Second Name",80);
            listView1.Columns.Add("Date of Enrolment",100);
            listView1.Columns.Add("Gender",60);
            foreach (Person p in people)
            {
                p.GetPerson(out string FaN, out string FiN, out string SN, out DateTime DOE, out char G);
                this.listView1.Items.Add(new ListViewItem (new string[] { FaN, FiN, SN, DOE.ToString("dd/MM/yyyy"), G.ToString() }));
            }
            save_loc = old_save_loc;
        }
        public String save_loc
        {
            get { return this.TXT_FILE_LOC.Text; }
            set { this.TXT_FILE_LOC.Text = value; }
        }
        private void set_fields()
        {
            if (listView1.SelectedIndices.Count == 0) { return; }
            ListViewItem item = listView1.Items[listView1.SelectedIndices[0]];
            this.TXT_FIRST_NAME.Text = item.SubItems[1].Text;
            this.TXT_SEC_NAME.Text = item.SubItems[2].Text;
            this.TXT_FAM_NAME.Text = item.SubItems[0].Text;
            this.TXT_DOE.Text = item.SubItems[3].Text;
            this.TXT_GENDER.Text = item.SubItems[4].Text;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_fields();
        }
        private void save_entry()
        {
            ListViewItem item = this.listView1.Items[this.listView1.SelectedIndices[0]];
            item.SubItems[1].Text = this.TXT_FIRST_NAME.Text;
            item.SubItems[2].Text = this.TXT_SEC_NAME.Text;
            item.SubItems[0].Text = this.TXT_FAM_NAME.Text;
            item.SubItems[3].Text = this.TXT_DOE.Text;
            item.SubItems[4].Text = this.TXT_GENDER.Text;
            this.listView1.Items[this.listView1.SelectedIndices[0]] = item;
        }
        private void error_message(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           //MessageBoxIcon.Warning // for Warning  
                           //MessageBoxIcon.Error // for Error 
                           //MessageBoxIcon.Information  // for Information
                           //MessageBoxIcon.Question // for Question 
        }
        private void Edit_entries_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(TXT_DOE.Text, out DateTime d))
            {
                set_fields();
                error_message("The date was not entered in the correct format. Please enter in dd/MM//yyyy format",
                    "Date of enrolment field error");
                return;
            }
            if (d>DateTime.Now)
            {
                set_fields();
                error_message("The date was in the future. Please enter a date in the past",
                    "Date of enrolment field error");
                return;
            }
            if (!char.TryParse(TXT_GENDER.Text, out char c))
            {
                set_fields();
                error_message("You can only enter either a M or F in the gender field." ,
                    "Gender field error");
                return;
            }
            if (c!='M' && c!='F')
            {
                set_fields();
                error_message("You can only enter either a M or F in the gender field.",
                    "Gender field error");
                return;
            }
            if (TXT_FAM_NAME.Text.Contains(" ") || TXT_FAM_NAME.Text =="")
            {
                set_fields();
                error_message("There is an issue with the Family name field. " ,
                    "Family name field error");
                return;
            }
            if(TXT_FIRST_NAME.Text.Contains(" ") || TXT_FIRST_NAME.Text == "")
            {
                set_fields();
                error_message("There is an issue with the first name field. ",
                    "First name field error");
                return;
            }
            if (TXT_SEC_NAME.Text.Contains(" ") )
            {
                set_fields();
                error_message("There is an issue with the second name field. ",
                    "Second name field error");
                return;
            }
            this.BTN_FILE.Visible = true;
            save_loc="File not saved";
        }

        private void BTN_BACK_Click(object sender, EventArgs e){this.Close();}

        private void BTN_FILE_Click(object sender, EventArgs e)
        {
            string export = "";
            int k = this.listView1.Items.Count;
            for (int i = 0; i < k; i++)
            {
                ListViewItem item = this.listView1.Items[i];
                /*for (int j = 0; j < 5; j++)
                {
                    export = export + item.SubItems[j].Text + ",";
                }*/
                export = export +item.SubItems[0].Text + ","+ item.SubItems[1].Text + "," +
                    item.SubItems[2].Text + "," + item.SubItems[3].Text+","  + 
                    item.SubItems[4].Text + Environment.NewLine;
            }


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Select the save location";
            //saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                    StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                    writer.WriteLine(export);
                    writer.Dispose();
                    writer.Close();
                save_loc= saveFileDialog1.FileName;
                this.BTN_FILE.Visible = false;
            }
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_entries_KeyDown(object sender, KeyEventArgs e)
        {

                int x = Convert.ToInt32('x');
                int X = Convert.ToInt32('X');
            if (e.KeyValue == x || e.KeyValue == X)
            {
                this.Close();

            }            
        }
    }
}
