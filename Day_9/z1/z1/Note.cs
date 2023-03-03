using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
        struct Note
        {
            public string surnameAndFirstName;
            public string phoneNumber;
            public int[] dateoOfBirth = new int[3];
            public Note(string surnameAndFirstName, string phoneNumber, int[] dateoOfBirth)
            {
                this.surnameAndFirstName = surnameAndFirstName;
                this.phoneNumber = phoneNumber;
                this.dateoOfBirth = dateoOfBirth;
            }
            public override string ToString()
            {
                return (string.Format(@"
                                    surname and first name: {0}
                                    phone Number: {1}
                                    Date of Birth: {2}", surnameAndFirstName, phoneNumber, PrintBirthDate(dateoOfBirth)));
            }

            private string PrintBirthDate(int[] dateoOfBirth)
            {
                string dateToString = "";
                for (int i = 0; i < dateoOfBirth.Length; i++)
                {
                    dateToString = dateToString + " " + dateoOfBirth[i];
                }
                return dateToString;
            }
        }
}
