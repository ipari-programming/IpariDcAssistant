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
        static List<string> filenames = new List<string>() {
            "student.csv", "students.csv"
        };

        public static List<Student> ReadStudents()
        {
            string filename = string.Empty;

            filenames.AddRange(Directory.GetDirectories(Directory.GetCurrentDirectory()));

            for (int i = 0; i < filenames.Count; i++)
            {
                if (!filenames[i].Contains(".csv")) filenames[i] += "/students.csv";
                if (File.Exists(filenames[i]))
                {
                    filename = filenames[i];
                    break;
                }
            }
            if (filename == string.Empty) return new List<Student>() { new Student("DIÁKOK FÁJL NEM TALÁLHATÓ", 0, "") };

            // Load file if found
            List<Student> students = new List<Student>();

            string[] lines = File.ReadAllLines(filename);

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
