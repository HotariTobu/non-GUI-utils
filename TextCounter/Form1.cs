using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Encoding se = Encoding.GetEncoding("Shift_JIS");

        private string last = "";

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numericUpDown1.Focused)
            {
                return;
            }

            string text = Clipboard.GetText();
            if (!last.Equals(text))
            {
                int l1 = text.Length;
                int l2 = se.GetByteCount(text);
                decimal fa = numericUpDown1.Value;
                label2.Text = $"{l1}, {l2}, {l1 * fa}, {l2 * fa}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool drag;
        private Point baseP;
        private Point lastP;

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            baseP = Location;
            lastP = Cursor.Position;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point point = Cursor.Position;
                Location = new Point(baseP.X + point.X - lastP.X, baseP.Y + point.Y - lastP.Y);
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
