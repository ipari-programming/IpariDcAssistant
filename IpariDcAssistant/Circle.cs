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
    public partial class Circle : Control
    {
        public Circle()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.FillEllipse(new SolidBrush(ForeColor), 0, 0, Width, Height);
            pe.Graphics.DrawString(Text, Font, new SolidBrush(Color.White), 8, 8);
        }
    }
}
