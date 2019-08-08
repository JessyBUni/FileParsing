using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Coursework
{
    public class Person
    {
        
            private string FirstName;
            public void set_FirstName(string name) { this.FirstName = name; }
            public string get_FirstName() { return this.FirstName; }

            public string FamilyName;
            public void set_FamilyName(string name) { this.FamilyName = name; }
            public string get_FamilyName() { return this.FamilyName; }

            private string SecondName;
            public void set_SecondName(string name) { this.SecondName = name; }
            public string get_SecondName() { return this.SecondName; }

            private DateTime DateOfEnrol;
            public void set_DateOfEnrol(DateTime date) { this.DateOfEnrol = date; }
            public DateTime get_DateOfEnrol() { return this.DateOfEnrol; }

            private char Gender;
            public void set_Gender(char c) { this.Gender = c; }
            public char get_Gender() { return this.Gender; }


            public void SetPerson(string FmN, string FiN, string SN, DateTime DOE, char G)
            {
                FamilyName = FmN;
                FirstName = FiN;
                SecondName = SN;
                DateOfEnrol = DOE;
                Gender = G;
            }
            public void GetPerson(out string FmN, out string FiN, out string SN, out DateTime DOE, out char G)
            {
                FmN = FamilyName;
                FiN = FirstName;
                SN = SecondName;
                DOE = DateOfEnrol;
                G = Gender;
            }
        
    }
}
