using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace answer2
{
    public partial class Form_MyGame : Form
    {
        int limitTimer = 0; //사용자가 설정하는 제한 시간
        int answer = 0;
        int nowtime = 0;
        public Form_MyGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_limit.Enabled = false;
            nowtime = 0;

            label2.Text = "Game Start!!!";
            answer = new Random().Next(1, 26);//1이상 25이하. 
            Console.WriteLine("answer : " + answer);

            int count = 1; 
            //버튼을 코드상에서 그려주는 부분
            for(int i = 0; i<5; i++)
            {
                for(int j = 0; j<5; j++)
                {
                    Button button = new Button();
                    Point point = new Point(); //컴포넌트들 위치값이 Point 타입이다. 참고로 이건 구조체로 만들어짐
                    point.X = 115 * j;
                    point.Y = 50 * i;
                    button.Location = point;
                    button.Click += Button_Click;
                    button.Text = count.ToString();
                    count++;
                    Controls.Add(button); //Controls = Form1에 있는 모든 컴포넌트들을 의미함
                }
            }

            timer_limit.Enabled = true;
            try
            {
                limitTimer = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                nowtime = -1;
            }
        }

        //sender = 이벤트를 발생시키는 주체
        private void Button_Click(object sender, EventArgs e)
        {
            if( ((Button)sender).Text == answer.ToString()  )
            {
                label2.Text = "you win";
                nowtime = 0;
                timer_limit.Enabled = false;
            }
            else
            {
                label2.Text = "이거 보물 아님";
            }
        }

        private void timer_limit_Tick(object sender, EventArgs e)
        {
            nowtime++;
            //nowtime = -1 -> 시간제한을 잘못걸었을 때
            if (nowtime >= limitTimer || nowtime == -1)
            {
                label2.Text = "Game Over!!";
                nowtime = 0;
                timer_limit.Enabled = false;
            }
        }
    }
}
