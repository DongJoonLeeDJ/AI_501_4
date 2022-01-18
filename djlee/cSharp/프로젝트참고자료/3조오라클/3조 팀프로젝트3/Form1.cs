using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3조_팀프로젝트3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Owner = this;
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Owner = this;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Owner = this;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Owner = this;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Owner = this;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Owner = this;
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Owner = this;
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
