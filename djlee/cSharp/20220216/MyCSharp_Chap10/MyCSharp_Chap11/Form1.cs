using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap11
{
    public partial class Form1 : Form
    {
        delegate void TestFunc(); //새로운 자료형 선언
        //함수를 저장
        //반환형 없고 매개변수가 없는 함수만 저장 가능

        void Hello()
        {
            MessageBox.Show("Hello Everyone");
        }
        void Bye()
        {
            MessageBox.Show("Bye Bye Bye~");
        }
        

        //매개변수랑 반환형 없는 함수를 t라는 변수에 저장 후, c 번 호출
        void DoDelegateFunc(TestFunc t, int c) //함수 안에 또 다른 함수를 호출하는 것 콜백. 
        {
            for (int i = 0; i < c; i++) //함수 내에서 호출되는 함수를 콜백함수
                t();
        }

        public Form1()
        {
            InitializeComponent();
            //DoDelegateFunc(Hello, 2);
            //DoDelegateFunc(Bye, 1);


            button_use_Delegate.Click += delegate (object sender, EventArgs e) { MessageBox.Show("Test"); };
            button_useLamda.Click += (sender, e) => { MessageBox.Show("Test Lamda"); };

            button_use_Delegate.Click += addFunc;
            button_use_Delegate.Click -= addFunc;   //이벤트 빼는 것도 됨. 단. 이때는 함수가 addFunc처럼 선언이 되어 있어야 한다.

            //button_useLamda.Click -= (sender, e) => { MessageBox.Show("Test Lamda"); }; //위에서 만든 람다와 '주소'가 다름.(형태는 똑같지만 메모리에 저장된 주소 다름)



        }

        private void addFunc(object sender, EventArgs e)
        {
            MessageBox.Show("한 번 Click시 여러개의 메소드가 호출되게 할 수 있어여");
        }


        //단순 호출
        private void button1_Click(object sender, EventArgs e)
        {
            Hello();
            Hello();
        }

        //단순 호출
        private void button2_Click(object sender, EventArgs e)
        {
            Bye();
            Bye();
            Bye();
            Bye();
            Bye();
        }

        //단순 호출(반복문)
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
                Hello();
        }

        //단순 호출(반복문)
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                Bye();
        }

        //TestFunc 타입의 변수에 메소드를 집어넣고, 호출하는 방식
        private void button6_Click(object sender, EventArgs e)
        {
            TestFunc t = Hello;
            t();
        }

        //TestFunc 타입의 변수에 메소드를 집어넣고, 호출하는 방식
        private void button5_Click(object sender, EventArgs e)
        {
            TestFunc t = Bye;
            t();
        }

        //Hello를 매개변수로 넣고(매개변수랑 반환형없는 함수), 횟수(2)를 넣고 출력
        private void button8_Click(object sender, EventArgs e)
        {
            DoDelegateFunc(Hello, 2);
        }

        //Bye를 매개변수로 넣고(매개변수랑 반환형없는 함수), 횟수(5)를 넣고 출력
        private void button7_Click(object sender, EventArgs e)
        {
            DoDelegateFunc(Bye, 5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //delegate () { MessageBox.Show("Say Hello"); }를 2번 호출
            //delegate () { MessageBox.Show("Say Hello"); }는 DoDelegateFunc 안에서'만' 선언된 임시 함수
            //익명 델리게이트. 함수를 따로 선언해두는 것이 아닌 즉석에서 선언해서 쓰는 것
            DoDelegateFunc(delegate () { MessageBox.Show("Say Hello"); }, 2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //익명 델리게이트를 더  축약한 형태 : 람다(함수를 따로 선언해두는 것이 아닌 즉석에서 선언해서 쓰는 것)
            DoDelegateFunc( () => { MessageBox.Show("Say Hello"); }, 2);
        }

        delegate string myStringValue(string str);

        string changeBig(string str)
        {
            return str.ToUpper(); //대문자로 다 바꿔서 반환함
        }
        string changeSmall(string str)
        {
            return str.ToLower(); //소문자로 다 바꿔서 반환함.
        }

        void ShowChange(myStringValue s, string str)
        {
            MessageBox.Show("원본 : "+ str  + "변경 후 "+ "["+s(str)+"]");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            myStringValue a = changeBig;
            myStringValue b = changeSmall;

            string msg1 = a(textBox1.Text);
            string msg2 = b(textBox1.Text);

            MessageBox.Show(msg1+msg2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ShowChange(changeSmall, textBox1.Text);
        }

        //글자 뒤집어서 출력
        //글자 뒤집는 함수를 따로 만들진 않았고
        //이 함수는 여기에서'만' 쓰임
        private void button13_Click(object sender, EventArgs e)
        {

            //str은 매개변수, str=textBox1.Text
            ShowChange(delegate (string str)
            {
                char[] charArr = str.ToCharArray(); //캐릭터 배열로 변경
                Array.Reverse(charArr); //순서 뒤집기
                return new string(charArr); //charArr을 이용한 문자열 만들어서 반환
            }, textBox1.Text);


        }

        private void button14_Click(object sender, EventArgs e)
        {
            //a는 매개변수이며 a=textBox1.Text
            ShowChange(  (a) => {

                char[] charArr = a.ToCharArray(); //캐릭터 배열로 변경
                Array.Sort(charArr); //abc 순으로 정렬하기
                return new string(charArr); //charArr을 이용한 문자열 만들어서 반환

            }, textBox1.Text);

        }

        delegate void callbackHell(TestFunc t, myStringValue s, string str);

        void myhell(TestFunc t, myStringValue s, string str)
        {
            t();
            string temp = s(str);
            MessageBox.Show("str의 원본 " + str);
            MessageBox.Show("str의 변경본 " + temp);
        }


        private void button15_Click(object sender, EventArgs e)
        {
            myhell(Hello, changeBig, textBox1.Text);

            myhell(() => { MessageBox.Show(textBox1.Text + "안녕"); }, (a) => { return a.ToLower() + a.ToUpper(); }, textBox1.Text);

            //델리게이트를 이용해서 새로운 함수
            callbackHell abc = (aa, bb, cc) => { aa(); string s = bb(cc); MessageBox.Show(s);};
            
            abc(Hello, changeBig, textBox1.Text);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(() => { for (int i = 0; i < 100; i++) { Console.Write("A"); } });
            Thread b = new Thread(() => { for (int i = 0; i < 100; i++) { Console.Write("B"); } });
            Thread c = new Thread(() => { for (int i = 0; i < 100; i++) { Console.Write("C"); } });

            //쓰레드 a,b,c는 각자 A나 B나 라는 1개의 글자를 출력하는 메소드(100개씩)
            //원래대로라면 A를 100개찍고 그 다음에 B를 100개 찍고 그 다음에 C를 100개 찍음
            //쓰레드는 시분할시스템이 적용되어 있으므로 A를 100개 찍는 와중에 B를 100개 찍으려고 하다가 C도 찍고 A도 찍고 다시 B도 찍는 형식이다.

            a.Start();
            b.Start();
            c.Start();

        }
    }
}
