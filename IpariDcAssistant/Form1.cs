using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpariDcAssistant
{
    public partial class Form1 : Form
    {
        List<Student> students;

        public Form1()
        {
            InitializeComponent();
            students = IO.ReadStudents();
            lbSearch.Items.AddRange(students.ToArray());
        }

        private void Search(object sender, EventArgs e)
        {
            lbSearch.Items.Clear();
            lbSearch.Items.AddRange(students.Where(r => r.Year == (int)numSearch.Value && r.Major == cbSearch.Text).ToArray());
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            lbSearch.Items.Clear();
            lbSearch.Items.AddRange(students.ToArray());
        }

        private void tbStudent_TextChanged(object sender, EventArgs e)
        {
            if (tbStudent.Text.Length < 3) return;

            List<Student> ans;
            try
            {
                ans = students.Where(r => r.Name.ToLower().Contains(tbStudent.Text.ToLower())).ToList();
            }
            catch
            {
                ans = new List<Student>() { new Student("Nincs találat!", 0, "XD") };
            }

            lblStudent.Text = string.Empty;
            foreach (Student student in ans)
            {
                lblStudent.Text += $"{student.Name} - {student.Year}.{student.Major}" + Environment.NewLine + Environment.NewLine;
            }
        }
    }
}
