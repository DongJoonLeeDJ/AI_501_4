using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1, button1과 같은 것들을 컨트롤 혹은 컴포넌트라고 부름!
            Random r = new Random();
            label1.Text = r.Next(10).ToString();//0~9까지의 값 나옴
        }

        //sender : 이벤트를 호출시키는 주체.
        //단 그 주체의 Text값등을 보고 싶다면 아래처럼 강제형변환 필요함
        
        //e : 이벤트에 대한 부가적인 정보인데, 프로그램 종료같은 이벤트가 아니면
        //별 다른 게 없음
        //FormClose 계열인 경우엔 종료원인등이 나옴
        private void buttonbutton(object sender, EventArgs e)
        {
            
            MessageBox.Show(e.ToString() + ((Button)sender).Text + "안녕하십니가!!!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] lotto = new int[7];
            for(int i = 0; i<7; i++)
            {
                int num = new Random().Next(45) + 1;
                if (lotto.Contains(num) == false)
                    lotto[i] = num;
                else
                    i--;
            }
            Array.Sort(lotto);
            label1.Text = lotto[0].ToString();
            label2.Text = lotto[1].ToString();
            label3.Text = lotto[2].ToString();
            label4.Text = lotto[3].ToString();
            label5.Text = lotto[4].ToString();
            label6.Text = lotto[5].ToString();
            label7.Text = lotto[6].ToString();

            // 궁금해하시는 분들을 위한 추가
            /*
             1번부터 10번까지는 노란색입니다.
            11번 부터 20번까지는 파란색입니다.
            21번부터 30번까지는 빨간색입니다.
            31번부터 40번까지는 검은색입니다.
            41번부터 45번까지는 초록색입니다.
             */

            Label[] labels = { label1, label2, label3, label4, label5, label6, label7 };
            for (int i = 0; i < 7; i++)
            {

                labels[i].BackColor = Color.Transparent;
                if (int.Parse(labels[i].Text) <= 10)
                {
                    labels[i].ForeColor = Color.Yellow;
                    labels[i].BackColor = Color.Black;
                }
                else if (int.Parse(labels[i].Text) <= 20)
                    labels[i].ForeColor = Color.Blue;
                else if (int.Parse(labels[i].Text) <= 30)
                    labels[i].ForeColor = Color.Red;
                else if (int.Parse(labels[i].Text) <= 40)
                    labels[i].ForeColor = Color.Black;
                else if (int.Parse(labels[i].Text) <= 45)
                    labels[i].ForeColor = Color.Green;

            }

        }
    }
}
