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
    public partial class Form2 : Form, IObserver
    {
        public Form2()
        {
            InitializeComponent();
        }
        //ISubject를 구현한 객체 : Form1(MainForm)
        //ISubject를 구현한 객체에서
        //registerObserver를 호출한다.
        //registerObserver는 IObserver를 구현한 객체들만
        //모아놓은 리스트에 IObserver를 구현한 객체를 추가한다.
        //즉 이 생성자는 ISubject를 구현한 객체에서
        //지금 이 객체(Form2)를 등록시킬 것이다.
        public Form2(ISubject sub)
        {
            InitializeComponent();
            sub.registerObserver(this);
        }

        public void update(string value)
        {
            textBox1.Text = value;
        }
    }
}
