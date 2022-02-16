using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap10
{
    public partial class Form4 : Form
    {
        Form2 fb2;
        Form3 fb3;
        ISubject sub; //Form1(왜냐면 ISubject 인터페이스를 구현한 객체이므로)
        public Form4()
        {
            InitializeComponent();
        }

        //Form4를 생성함과 동시에 매개변수로 다른 폼들을 불러옴
        public Form4(ISubject sub, Form2 fb2, Form3 fb3)
        {
            InitializeComponent();//디자인창에 버튼들 다 띄우고
            this.sub = sub; //Form4 안에 있는 변수들이랑 Form2, Form3, ISubject를 구현한 Form1을 연결
            this.fb2 = fb2;
            this.fb3 = fb3;
        }

        //Form2 제거
        private void button1_Click(object sender, EventArgs e)
        {
            sub.unregisterObserver(fb2);
        }

        //Form3 제외
        private void button2_Click(object sender, EventArgs e)
        {
            sub.unregisterObserver(fb3);
        }
        //Form2 추가
        private void button3_Click(object sender, EventArgs e)
        {
            sub.registerObserver(fb2);
        }
        //Form3 추가
        private void button4_Click(object sender, EventArgs e)
        {
            sub.registerObserver(fb3);
        }
    }
}
