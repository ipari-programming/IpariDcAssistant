using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpariDcAssistant
{
    class Student
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public string Major { get; private set; }

        public Student() { }
        public Student(string name, int year, string major)
        {
            Name = name;
            Year = year;
            Major = major;
        }

        public override string ToString()
        {
            return $"{Name} - {Year}.{Major}";
        }
    }
}
