using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_from_06_03
{
    public partial class Form1 : Form
    {
        int a;
        int b;

        BankAccount ldj1;
        BankAccount ldj2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "a=" + a + ", b=" + b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = int.Parse(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ldj1 고객
            //Id랑 잔액을 텍스트박스에서 받아옴.

            ldj1 = new BankAccount();
            ldj1.Name = "이동준";
            ldj1.Id = textBox3.Text;
            ldj1.deposit = int.Parse(textBox4.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ldj2 = ldj1; //둘은 이동준 즉 동명이인이라고 가정
            ldj2.Id = textBox5.Text;
            ldj2.deposit = int.Parse(textBox6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Environment.NewLine : \n이랑 동일
            //운영체제별로 개행문자가 다를 수 있는 데 그걸 맞춰주는 것
            MessageBox.Show($"ldj1의 이름 : {ldj1.Name}, ID : {ldj1.Id}, 잔액 : {ldj1.deposit} {Environment.NewLine} " +
                $"ldj2의 이름 : {ldj2.Name},  ID : {ldj2.Id}, 잔액 : {ldj2.deposit}");
        }

        void change(int a)
        {
            a = 100;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 10;
            change(a);
            MessageBox.Show("a="+a);
        }

        void change(BankAccount a)
        {
            a.deposit = 0;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ldj1 = new BankAccount();
            ldj1.deposit = 1000;
            change(ldj1);
            MessageBox.Show("ldj1의 통장 잔액은 " + ldj1.deposit+"이다.");
        }

        void change(ref int a)
        {
            a = 20;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = 10;
            change(ref a);
            MessageBox.Show("a는 " + a +"입니다!!!");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ldj1 = new BankAccount();
            ldj1.Name = "이동준";
            ldj1.Id = textBox10.Text;
            ldj1.deposit = int.Parse(textBox9.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ldj2 = new BankAccount(); //참조복사와는 다르게 메모리 영역을 새로 만들고
            ldj2.Name = ldj1.Name; //값을 하나하나 복사함
            ldj2.Id = textBox7.Text;
            ldj2.deposit = int.Parse(textBox8.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ldj1의 이름 : {ldj1.Name}, ID : {ldj1.Id}, 잔액 : {ldj1.deposit} {Environment.NewLine} " +
                $"ldj2의 이름 : {ldj2.Name},  ID : {ldj2.Id}, 잔액 : {ldj2.deposit}");
        }
    }
}
