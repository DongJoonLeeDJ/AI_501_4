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

        void changeColor(Label l)
        {
            l.BackColor = Color.Transparent;
            if (int.Parse(l.Text) <= 10)
            {
                l.ForeColor = Color.Yellow;
                l.BackColor = Color.Black;
            }
            else if (int.Parse(l.Text) <= 20)
                l.ForeColor = Color.Blue;
            else if (int.Parse(l.Text) <= 30)
                l.ForeColor = Color.Red;
            else if (int.Parse(l.Text) <= 40)
                l.ForeColor = Color.Black;
            else
                l.ForeColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //랜덤한 7개의 숫자를 뽑는다. 단 이 7개는 서로 중복되면 안 됨.
            int[] lotto = new int[7];
            //i<7 이렇게 적어도 되긴 함.
            for (int i = 0; i < lotto.Length; i++)
            {
                //int num = new Random().Next(45) + 1;
                Random random = new Random();
                int num = random.Next(45) + 1;
                if (lotto.Contains(num)) //이미 존재한다면... i값을 깎는다. 그러면 다음 단계에서 i가 원상복구됨
                    i--;
                else
                    lotto[i] = num;
            }
            Array.Sort(lotto);

            num1.Text = lotto[0].ToString();
            num2.Text = lotto[1].ToString();
            num3.Text = lotto[2].ToString();
            num4.Text = lotto[3].ToString();
            num5.Text = lotto[4].ToString();
            num6.Text = lotto[5].ToString();
            num7.Text = lotto[6].ToString();

            //이걸 더 줄이고 싶다면, Label 배열 안에 num들을 넣고, 각각에 대해서
            //changeColor 돌리면 됨
            changeColor(num1);
            changeColor(num2);
            changeColor(num3);
            changeColor(num4);
            changeColor(num5);
            changeColor(num6);
            changeColor(num7);



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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
