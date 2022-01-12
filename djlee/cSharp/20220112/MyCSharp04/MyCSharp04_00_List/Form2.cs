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
    public partial class Form2 : Form
    {

        List<string> list = new List<string>();

        public Form2()
        {
            InitializeComponent();

            Random random = new Random();
            button1.Text = random.Next(100).ToString();
            button5.Text = button1.Text;
            button2.Text = random.Next(100).ToString();
            button6.Text = button2.Text;
            button3.Text = random.Next(100).ToString();
            button7.Text = button3.Text;
            button4.Text = random.Next(100).ToString();
            button8.Text = button4.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {

        }

        void addText(string text) //list라는 stringList에 텍스트추가 하고 ListText(=label)에 글자적기
        {
            list.Add(text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }
        void removeText(string text)//list라는 stringList에 텍스트삭제 하고 ListText(=label)에 글자적기
        {
            list.Remove(text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addText(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addText(((Button)sender).Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //as 로써
            //sender 변수(=object변수)를 Button으로 형변환
            addText((sender as Button).Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addText((sender as Button).Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            removeText((sender as Button).Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            removeText((sender as Button).Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            removeText((sender as Button).Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            removeText((sender as Button).Text);
        }
    }
}
