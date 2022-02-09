using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_chap08_01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int value1);
            int.TryParse(textBox2.Text, out int value2);
            MessageBox.Show("두 숫자의 합은 " + value1+value2+ "이다.");
            MessageBox.Show("두 숫자의 합은 " + (value1+value2)+ "이다."); //괄호 안 하면 그냥 글자 더하기 됨
        }
    }
}
