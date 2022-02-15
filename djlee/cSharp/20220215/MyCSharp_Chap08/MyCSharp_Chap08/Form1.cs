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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Twice  t = new Twice();
            MessageBox.Show(textBox1.Text+"의 2배는 " + t[int.Parse(textBox1.Text)]+"이다.");
            t[int.Parse(textBox1.Text)] = 100; //set을 호출
            MessageBox.Show(textBox1.Text+"의 2배는 " + t[int.Parse(textBox1.Text)]+"이다.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySquare m = new MySquare();
            MessageBox.Show(textBox1.Text+"의 제곱은 " + m[int.Parse(textBox1.Text)]+"이다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //visual studio 2015까진 이렇게 적음
            int a;
            bool result = int.TryParse(textBox1.Text, out a);

            if(result) //result값이 true일 때만 출력
                MessageBox.Show(textBox1.Text+"의 제곱은"+new MySquare()[a] );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //visual studio 2017부턴 TryParse 함과 동시에 변수 선언 가능
            bool result = int.TryParse(textBox1.Text, out int a);
            if(result)
                MessageBox.Show(textBox1.Text + "의 제곱은" + new MySquare()[a]);
        }

        //이 메소드는 return은 없는 데,
        //반드시 x와 y에 값을 대입시켜야 됨.
        void nextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + (x * vx);
            ry = y + (y * vy);
            //rx와 ry의 값이 바뀌면서 main에도 영향을 끼침
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int x);
            int.TryParse(textBox3.Text, out int y);

            int.TryParse(textBox4.Text, out int vx);
            int.TryParse(textBox5.Text, out int vy);


            nextPos(x, y, vx, vy, out x, out y);

            label5.Text = "x의 다음 위치 : " + x;
            label6.Text = "y의 다음 위치 : " + y;

        }

        //변수 x와 y의 참조자(=위치)를 가져옴
        //여기서 x , y 바꾸면 이 함수 호출하기 전이랑 값이 바뀜
        //ref 해당 변수를 직접 가리킴(참조한다)
        void swapFunc(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        void swapFunc(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //ref vs out
        //out은 반드시 out 키워드 붙은 변수에 값을 대입시켜줘야 함
        //ref는 값을 대입시키지 말고, 그냥 읽기만 해도 됨.
        //ref는 직접 변수에 접근해서 값을 바꾸기도 하고 값을 그냥 읽기도 함.

        //out은 직접 접근하는 게 아니고 또 다른 변수를 만들어서
        //그 값을 다른 변수에 적용시키는 것
        void swapFunc(int x, int y, out int rx, out int ry)
        {
            int temp = x;
            x = y;
            y = temp;
            rx = x;
            ry = y;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox6.Text, out int x);
            int.TryParse(textBox7.Text, out int y);
            swapFunc(x, y); //ref 없는 거. x와 y값 안 바뀜
            MessageBox.Show("x="+x+", y="+y);

            //ref 참조변수
            //배열, List, class로 만든 모든 인스턴스들이 다 여기에 해당됨

            swapFunc(ref x, ref y); //x와 y값이 바뀜
            label9.Text = "x=" + x;
            label10.Text = "y=" + y;

            swapFunc(x, y, out x, out y); //x와 y를 out을 통해서 바꿈. 
            //rx, ry라는 새로운 변수의 값을 x와 y에 보냄
            MessageBox.Show("x=" + x + ", y=" + y);
            
            int anotherX;
            int anotherY;
            //rx, ry값을 또 다른 변수들에 대입시키고
            //x, y 자체는 그대로 뒀음
            swapFunc(x, y, out anotherX, out anotherY);
            MessageBox.Show("anotherX=" + anotherX + ", anotherY=" + anotherY);
            MessageBox.Show("x=" + x + ", y=" + y);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //참고
            //MessageBox.Show 모달(뒤에꺼 조작 불가능)
            //알림창을 띄울 때 MessageBox를 쓰기보단 Form창을 새로 만들어서 쓰는 경우가 많다.

            //Show : 모달리스(Modeless)
            //뒤에꺼 선택이 되고, 창을 띄우고 밑에 코드도 실행됨

            //ShowDialog : 모달(Modal)
            //뒤에꺼 선택도 안 되고, 이 창을 닫아야지만 그 밑에 코드가 실행됨
            new Form2().ShowDialog(); //ShowDialog로 해놔서 뒤에꺼 클릭안됨 
            MessageBox.Show("Test");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();//Form1을 감춤
            new Form2().ShowDialog(); //이 부분에서 코드가 멈춤. 창을 꺼야 밑에 코드가 실행
            Show();//Form1을 드러냄
        }
    }
}
