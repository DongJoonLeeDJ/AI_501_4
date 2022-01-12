using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp04_00_List
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        void plus(int a) //copy & paste(복사 & 붙여넣기)
        {
            a++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100;
            plus(a);
            textBox1.Text = a.ToString();
        }

        void plus(TextBox t) //바로가기
        {
            t.Text = int.Parse(t.Text) + 1 + "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = 100+"";
            plus(textBox2);
        }

        void plus(Product p) //바로가기
        {
            p.price++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.price = int.Parse(textBox3.Text);
            plus(p);
            textBox3.Text = p.price.ToString();
        }
    }
}
