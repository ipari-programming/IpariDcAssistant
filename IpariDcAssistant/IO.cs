using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IpariDcAssistant
{
    static class IO
    {
        public static List<Student> ReadStudents()
        {
            if (!File.Exists("students.csv"))
                return new List<Student>() { new Student("HIÁNYZIK A students.csv FÁJL!", 0, "XD") };

            List<Student> students = new List<Student>();

            string[] lines = File.ReadAllLines("students.csv");

            string[] data;
            foreach (string line in lines)
            {
                data = line.Split(',');
                students.Add(new Student(data[0], int.Parse(data[1]), data[2]));
            }

            return students;
        }
    }
}
