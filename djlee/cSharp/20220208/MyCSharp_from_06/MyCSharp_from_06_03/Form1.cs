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
            //다른 이벤트들은 프로그램 시작전에 이미 등록되어있지만
            //이 이벤트를 프로그램을 시작해야지 이 코드를 통해서 등록됨
            button14.Click += Button14_Click;
            button14.Click += test;
            //button14 누를 때 2개의 메소드가 호출됨...(Button14_Click, test)
        }
        //object sender : 이벤트 발생 주체
        //EventArgs e : 이벤트와 관련있는 정보들... 아무것도 없는 경우가 많음
        private void test(object sender, EventArgs e)
        {
            MessageBox.Show("클릭시 이벤트 여러 개 나오게 할 수 있음");
            ((Button)sender).Text = "버튼 14!!!";
        }

        //button14를 클릭했을 때의 추가될 이벤트
        private void Button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button 14를 클릭했습니다.");
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

        void swap(ref int a, ref int b) //원본(=button_swap_Click)에 있는 변수의 위치(=참조값) 받아와서 변경
        {
            int temp = a;
            a = b;
            b = temp;
        }
        void swap(int a, int b) //원본(=button_swap_Click에 있는 변수들) 에 영향미치지 않음
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox_one.Text);
            int b = int.Parse(textBox_two.Text);
            swap(ref a, ref b);
            label_one_result.Text += " a = " + a;
            label_two_result.Text += " b = " + b;

            swap(a, b); //이건 안 바뀜....(a와 b가 바뀐 상태 그대로 출력하고 있음)
            MessageBox.Show("a="+a+", b="+b);

        }

        //Interval = 1000
        //Enable = True
        //1초에 한 번 이 메소드 실행
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");
        }
    }
}
