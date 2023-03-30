using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.Models
{
    public class Record
    {
        public string Surname { get; set; }
        public int DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"-------->Surname {Surname}")
                .AppendLine($"\tDate Of Birth {DateOfBirth}")
                .AppendLine($"\tPhone Number {PhoneNumber}")
                .ToString();
        }
    }
}
