using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap08
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        BankAccount a;
        BankAccount b;
        KBBankAccount kbb;
        KBBankAccount kbb2;

        private void button1_Click(object sender, EventArgs e)
        {
            a = new BankAccount();
            a.name = textBox1.Text;
            a.deposit = int.Parse(textBox2.Text);

            kbb = new KBBankAccount();
            kbb.name = textBox1.Text;
            kbb.deposit = int.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //동명이이인데, 잔금만 변경
            b = a;
            b.deposit = int.Parse(textBox3.Text);
            kbb2 = kbb;
            kbb2.deposit = int.Parse(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = $"a의 고객명 : {a.name}, a의 잔액 : {a.deposit}\n" +
                $"b의 고객명 : {b.name}, b의 잔액 : {b.deposit}\n" +
                $"kbb의 고객명 : {kbb.name}, kbb의 잔액 : {kbb.deposit}\n" +
                $"kbb2의 고객명 : {kbb2.name}, kbb2의 잔액 : {kbb2.deposit}\n";
            label1.Text = result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }
    }
}
