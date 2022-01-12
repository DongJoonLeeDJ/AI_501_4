using System;
using System.Collections;
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
    public partial class Form1 : Form
    {

        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
            btn_list_study.Text = "안녕";

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

        private void btn_list_study_Click(object sender, EventArgs e)
        {
            //자바의 ArrayList랑 C#의 List가 유사하다.
            List<int> numbers = new List<int>();
            numbers.Add(1000);
            numbers.Add(-1000);
            numbers.Sort();
            numbers.Remove(1000); //값이 1000인걸 삭제함
            MessageBox.Show("Test"+numbers[0]); //배열처럼 접근가능함.(자바에선 안 됐던 걸로 기억함)
            foreach (var item in numbers)
            {
                //item+"" 이랑 item.ToString()이랑 사실상 똑같은 코드
                //+ 연산이 "" 즉 문자열 만나면 그뒤부터는 문자열로써 취급
                //즉 10+100 = 110 이지만, ""+10+100 하면 10100이 됨.
                MessageBox.Show(item+""); //-1000, 1000 이렇게 정렬된 걸 하나씩 출력
            }
            MessageBox.Show(10+100+"");
            MessageBox.Show(""+10+100);

            //참고로 C#의 ArrayList는 좀 다름
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add("가즈아");
            a.Add(numbers);
            MessageBox.Show(""+a[0]+a[1]+a[2]);

        }

        //button1~4까지는 추가
        //button5~8까지는 제건
        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(button1.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(button2.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(button3.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(button4.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Remove(button5.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Remove(button6.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            list.Remove(button7.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            list.Remove(button8.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.name = textBox1.Text;
            p.price = int.Parse(textBox2.Text);
            p.introduce();
            MessageBox.Show("pCount="+Product.pCount);
            Product p2 = new Product();
            p2.name = textBox3.Text;
            p2.price = int.Parse(textBox4.Text);
            p2.introduce();
            MessageBox.Show("pCount=" + Product.pCount);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"현재 제품 개수는 {Product.showCount()}입니다.");
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //new Form2().Show();//모달리스, Modeless
            new Form2().ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
