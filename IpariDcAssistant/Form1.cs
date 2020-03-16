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
        }

        #region Room select
        string selectedRoom = "";

        private void circleCsáki_Click(object sender, EventArgs e)
        {
            lbRooms.Items.Clear();
            lbRooms.Items.AddRange(new string[] { "# információ", "# változtatások" });
            lblServerName.Text = "Csáki";
        }

        private void circleIpari_Click(object sender, EventArgs e)
        {
            lbRooms.Items.Clear();
            lbRooms.Items.AddRange(new string[] { "# everyone", "# osztályok", "# diákok" });
            lblServerName.Text = "Ipari";
        }

        private void lbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoom = lbRooms.SelectedItem.ToString().Substring(2);

            tbOutput.Text = string.Empty;
            tbInput.Text = string.Empty;
            switch (selectedRoom)
            {
                case "információ":
                    tbOutput.Text = Storage.Info;
                    break;

                case "változtatások":
                    tbOutput.Text = $"Jelenlegi verzó: {Storage.Version}" + Environment.NewLine;
                    foreach (string text in Storage.Changelog)
                    {
                        tbOutput.Text += Environment.NewLine + text;
                    }
                    break;

                case "everyone":
                    if (MessageBox.Show("Az összes diák kiírása megterhelő lehet egy gyengébb gépnek. Folytatod?", "@everyone", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                    foreach (Student student in students)
                    {
                        tbOutput.Text += student + Environment.NewLine;
                    }
                    break;

                case "osztályok":
                    tbOutput.Text = "Írj be egy osztályt! Például 9.G vagy 13.C";
                    break;

                case "diákok":
                    tbOutput.Text = "Kezdj el írni egy nevet!";
                    break;

                default:
                    tbOutput.Text = $"Üdv a(z) {selectedRoom} szobában! Ez egy üres szoba.";
                    break;
            }
        }
        #endregion

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            List<Student> ans;
            switch (selectedRoom)
            {
                case "osztályok":
                    tbOutput.Text = string.Empty;
                    int year = 9;
                    string major = "A";
                    try
                    {
                        year = int.Parse(tbInput.Text.Split('.')[0]);
                        major = tbInput.Text.ToUpper().Split('.')[1];
                    } catch { }
                    ans = students.Where(r => r.Year == year && r.Major == major).ToList();
                    if (ans.Count > 50) ans.RemoveRange(50, ans.Count - 50);
                    foreach (Student student in ans)
                        tbOutput.Text += student.ToString() + Environment.NewLine;
                    break;

                case "diákok":
                    tbOutput.Text = string.Empty;
                    ans = students.Where(r => r.Name.ToLower().Contains(tbInput.Text.ToLower())).ToList();
                    if (ans.Count > 50) ans.RemoveRange(50, ans.Count - 50);
                    foreach (Student student in ans)
                        tbOutput.Text += student.ToString() + Environment.NewLine;
                    break;

                default:
                    tbOutput.Text = $"<{students[new Random().Next(0, students.Count)].Name}> {tbInput.Text}";
                    break;
            }
        }
    }
}
