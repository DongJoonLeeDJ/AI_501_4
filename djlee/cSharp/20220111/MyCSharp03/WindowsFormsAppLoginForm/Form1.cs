using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //mbox
            MessageBox.Show("아직 준비중입니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"유저명은 {textBox1.Text}이며, 비밀번호는 {textBox2.Text}");
        }
    }
}
