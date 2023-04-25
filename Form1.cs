using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ShowUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rectangle r = new Rectangle();
                pictureBox1.Image = Image.FromFile(r.path);
            }
            if (radioButton2.Checked)
            {
                square s = new square();
                pictureBox1.Image = Image.FromFile(s.path);
            }
            if (radioButton3.Checked)
            {
                triangle t = new triangle();
                pictureBox1.Image = Image.FromFile(t.path);
            }
            if (radioButton4.Checked)
            {
                circle c = new circle();
                pictureBox1.Image = Image.FromFile(c.path);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }
    }
}
