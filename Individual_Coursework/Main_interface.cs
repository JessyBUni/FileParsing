using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Coursework
{
    public partial class Main_interface : Form
    {
        // global variables to contain the infomration needed in all functions (unsorted and sorted)
        List<Person> l_people = new List<Person>();
        List<Person>  sl_people = new List<Person>();

// main function
        public Main_interface()
        {
            InitializeComponent();
        }

        
        public int get_list_number()
        {
            /* function that retrieves the list number (n) indcated in the field (in form : n / total) 
             * that logs where we are situated in the entries
             * in : 
             * out : 
             *   int k : the list number 
             */

            // get field
            string pos = this.LBL_ENTRY_ED.Text;
            // cut seperate the characters
            string[] p = pos.Split('/');
            // take the first character ( the one with the number needed) and make it an int
            int k = Convert.ToInt32(p[0]);
            // return the number
            return k;
        }

        public void set_time_field()
        {
            /* function that sets the time span between the day the sudent enrolled andthe current time
             * in :
             * out :
             */

            // get the current datetime
            DateTime CurrentTime = DateTime.Now;
            // create a field to hold the enrolment date
            DateTime EnrolDate = new DateTime();
            // get the id value of the file currently on diplay in the fields (real ID for array is k-1)
            int k = get_list_number();
            // depending on if the display is sorted or not retireve the ênrolment date from the relevant list
            if (this.CB_SORT.SelectedIndex == 1) { EnrolDate = sl_people[k-1].get_DateOfEnrol(); }
            else { EnrolDate = l_people[k-1].get_DateOfEnrol(); }

            // display as per the radio button selected
            if (this.RB_DAY.Checked == true)// day
            {
                // get the time span in days
                TimeSpan interval = CurrentTime - EnrolDate;
                // display in relevant field
                this.TXT_TIME.Text = interval.Days.ToString() + " Days";
            }
            else if (this.RB_MONTH.Checked == true)//month
            {
                // use the date time format to calculate the time span in months
                int m = (CurrentTime.Month - EnrolDate.Month) + 12 * (CurrentTime.Year - EnrolDate.Year);
                // display in relevant field
                this.TXT_TIME.Text = m.ToString() + " Months";
            }
            else// year format
            {
                // use the datetime fomrat to calcuate the difference in years
                int m = CurrentTime.Year - EnrolDate.Year;
                // display in relevant field
                this.TXT_TIME.Text = m.ToString() + " Years";
            }
        }

        public void fill_page(int num)
        {
            /* function that diplays all infomration for the element indicated by the int num 
             * in the relevant fields on the window for interface
             * in :
             *      int num = id number to indicate the location of element in list 
             * out :
             */ 
            if (this.CB_SORT.SelectedIndex == 1)
            {
                this.sl_people[num].GetPerson(out string FaN, out string FiN, out string SN, out DateTime DOE, out char G);
                this.TXT_FIRST_NAME.Text = FiN;
                this.TXT_SEC_NAME.Text = SN;
                this.TXT_FAM_NAME.Text = FaN;
                this.TXT_DOE.Text = DOE.ToString("dd/MM/yyyy");
                this.TXT_GENDER.Text = G.ToString();
            }
            else
            {
                this.l_people[num].GetPerson(out string FaN, out string FiN, out string SN, out DateTime DOE, out char G);
                this.TXT_FIRST_NAME.Text = FiN;
                this.TXT_SEC_NAME.Text = SN;
                this.TXT_FAM_NAME.Text = FaN;
                this.TXT_DOE.Text = DOE.ToString("dd/MM/yyyy");
                this.TXT_GENDER.Text = G.ToString();
            }
        }
        private void OpenDisplayFile(string filename)
        {
            try
            {
                l_people.Clear();
                // open the file using stream reader
                StreamReader sr = new StreamReader(filename);
                // read the contents as a continuous string until the end
                string text = sr.ReadToEnd();
                // cut the long string using the "next line" indicator
                string[] entries = text.Split('\n');
                // get the number of lines in file
                int leng = entries.Length;
                // if the second to last line is the return character then discount it as it is surplus
                /*if (entries[leng - 2] == "\r")
                {
                    leng = leng - 1;
                }*/
                // required length is 10 
                // make sure laste entry is not empty
                if (entries[leng - 1] == "") { leng = leng - 1; }
                // make sure new last entry is not return char
                if (entries[leng - 1] == "\r") { leng = leng - 1; }
                if (leng > 10)
                { //throw error as is too long}
                    sr.Close();
                    error_message("There were too many entries for this program. The limit is 10 entries",
                        "Too many entries error");
                }
                // go though each line 
                for (int p = 0; p < leng; p++)
                {

                    // cut down the comma seperated file
                    string[] entry = entries[p].Split(',');
                    // make sure is long enough to fit the needs of the program (5 fields)
                    if (entry.Length >= 5)
                    {
                        // take the 4th entry (gender) and make it a char array to fit class needs
                        char[] Gen = entry[4].ToCharArray();
                        if (Gen[0] != 'M' && Gen[0] != 'F')
                        {
                            sr.Close();
                            error_message("One of the data fields was not correct", "Gender Field error");
                        }
                        // make the date of enrollment entrey (3rd) into a datetime as per the class requirements
                        if (!DateTime.TryParse(entry[3], out DateTime d))
                        {
                            sr.Close();
                            error_message("One of the data fields was not correct", "Date of Enrolment Field error");
                        }
                        DateTime Date = d;
                        if (entry[0] == "")
                        {
                            sr.Close();
                            error_message("One of the data fields was not correct", "Family Name Field error");
                        }
                        if (entry[1] == "")
                        {
                            sr.Close();
                            error_message("One of the data fields was not correct", "First Name Field error");
                        }
                        // person has to be declared here or will overide all other entries (class=ref type)
                        Person l_entry = new Person();
                        // send the first 3 strings and the date and the first char in the gender parameter (avoid the comma)
                        l_entry.SetPerson(entry[0], entry[1], entry[2], Date, Gen[0]);
                        // add the element to the unsorted list
                        l_people.Add(l_entry);
                    }
                    else
                    {
                        sr.Close();
                        error_message("One of the fields did not contain enough entries", "Not enough entries");
                    }
                }
                // close the file
                sr.Close();
                // indicate which file was openend in the relevant field
                this.TXT_FILE_LOC.Text = filename;
                // indicate the eleemt being displayed and the total munber of entries
                this.LBL_ENTRY_ED.Text = "1 / " + l_people.Count.ToString();
                // fill the other fields with the info for the first entry
                fill_page(0);
                change_interface_buttons(true);
            }
            catch (IOException)
            {
                TXT_FILE_LOC.Text = "No file loaded.";
                change_interface_buttons(false);
            }
        }

        private void change_interface_buttons(bool activate)
        {
            this.button1.Enabled = activate;
            this.BTN_FIRST_ENTRY.Enabled = activate;
            this.BTN_LAST_ENTRY.Enabled = activate;
            this.BTN_NEXT_ENTRY.Enabled = activate;
            this.BTN_PREV_ENTRY.Enabled = activate;
            this.BTN_TIME.Enabled = activate;
            this.CB_SORT.Enabled = activate;
            this.RB_DAY.Enabled = activate;
            this.RB_MONTH.Enabled = activate;
            this.RB_YEAR.Enabled = activate;
        }

        private void error_message(string message , string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void BTN_OPEN_FILE_Click(object sender, EventArgs e)
        {//only show .txt files
            openFileDialog1.Filter = "Text Files|*.txt";
            // prompt on the top of the new window
            openFileDialog1.Title = "Select a Text File";
            // open the selection window
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) // Test result.
            {
                // take the filename
                string file = openFileDialog1.FileName;
                OpenDisplayFile(file);
            }
            else
            {
                TXT_FILE_LOC.Text = "No file loaded.";
            }
        }

        private void BTN_FIRST_ENTRY_Click(object sender, EventArgs e)
        {
            int k = l_people.Count;
            LBL_ENTRY_ED.Text = "1 / " + k.ToString();
            if (CB_SORT.SelectedIndex == 1)
            {
                fill_page(0);
            }
            else
            {
                fill_page(0);
            }
            
        }

        private void BTN_LAST_ENTRY_Click(object sender, EventArgs e)
        {
            int k = l_people.Count;
            LBL_ENTRY_ED.Text = k.ToString() + " / " + k.ToString();
            if (CB_SORT.SelectedIndex == 1)
            {
                fill_page(k-1);
            }
            else
            {
                fill_page(k-1);
            }
        }

        private void BTN_PREV_ENTRY_Click(object sender, EventArgs e)
        {
            int k = get_list_number();
            int leng = l_people.Count;
            if (k < 2)
            {
                k = leng + 1;
            }
            LBL_ENTRY_ED.Text = (k - 1).ToString() + " / " + leng.ToString();
            fill_page(k - 2);
            if (CB_SORT.SelectedIndex == 1)
            {
                fill_page(k-2);
            }
            else
            {
                fill_page(k-2);
            }

        }
        private void BTN_NEXT_ENTRY_Click(object sender, EventArgs e)
        {
            int k = get_list_number();
            int leng = l_people.Count;

            if (k >= leng)
            {
                k = 0;
            }
            LBL_ENTRY_ED.Text = (k + 1).ToString() + " / " + leng.ToString();
            fill_page(k);

        }

        private void Main_interface_KeyDown(object sender, KeyEventArgs e)
        {
            int x = Convert.ToInt32('x');
            int X = Convert.ToInt32('X');
            if (e.KeyValue == x||e.KeyValue == X)
            {
                this.Close();
            }
        }

        private void CB_SORT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_SORT.SelectedIndex == 1)
            {
                sl_people.Clear();
                List<Person> SortedList = l_people.OrderBy(Person=>Person.FamilyName).ToList();
                sl_people.AddRange(SortedList);
            }
            fill_page(0);
        }

        private void BTN_TIME_Click(object sender, EventArgs e) { set_time_field();}

        private void RB_YEAR_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_TIME.Enabled == true)
            {
                set_time_field();
            }
        }

        private void RB_MONTH_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_TIME.Enabled == true)
            {
                set_time_field();
            }
        }

        private void RB_DAY_CheckedChanged(object sender, EventArgs e)
        {
            if (BTN_TIME.Enabled == true)
            {
                set_time_field();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string save_loc = this.TXT_FILE_LOC.Text;
            if (CB_SORT.SelectedIndex == 1)
            {
                
                Edit_entries edit_form =new Edit_entries(sl_people,save_loc );
                this.Hide();
                edit_form.ShowDialog();
                save_loc = edit_form.save_loc;
                this.Show();
            }
            else {
                Edit_entries edit_form = new Edit_entries(l_people,save_loc);
                this.Hide();
                edit_form.ShowDialog();
                save_loc=edit_form.save_loc;
                this.Show();
            }
            if (save_loc!= "File not saved")
            {
                if (save_loc != this.TXT_FILE_LOC.Text)
                {
                    OpenDisplayFile(save_loc);
                }
            }
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {

        }
    }
}
