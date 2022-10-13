using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS3033_001_EX3
{
    public class Student
    {
        [Key]
        public string ID { get; set; }
        public string name { get; set; }
        public double grade { get; set; }
        public char letterGrade { get; set; }

        public Student() { }

        public char GetLetterGrade()
        {
            if (this.grade > 89)
            {
                return 'A';
            }
            else if (this.grade > 79)
            {
                return 'B';
            }
            else if (this.grade > 69)
            {
                return 'C';
            }
            else if (this.grade > 59)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        public override string ToString()
        {
            string str = string.Format($"{this.name}({this.ID}), Grade: {this.grade} ({this.GetLetterGrade()})");
            return str;
        }
    }
}
