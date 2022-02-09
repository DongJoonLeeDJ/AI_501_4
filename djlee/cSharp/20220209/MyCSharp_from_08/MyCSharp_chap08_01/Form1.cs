using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_chap08_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student<string> student = new Student<string>();
            student.Hakbeon = textBox1.Text;
            label1.Text = student.Hakbeon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student<int> student = new Student<int>();
            try
            {
                student.Hakbeon = int.Parse(textBox1.Text);
                label1.Text = student.Hakbeon + ""; //끝에 .ToString() 붙여도 됨
            }
            catch (Exception)
            {
                MessageBox.Show("학번은 숫자만 입력이 되요!");
                //throw;
            }
        }
    }
}
