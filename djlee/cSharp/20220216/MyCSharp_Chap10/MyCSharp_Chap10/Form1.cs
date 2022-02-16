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
    public partial class Form1 : Form, ISubject
    {

        //IObserver를 구현한 객체만 들어가 있다.
        List<IObserver> _observers = new List<IObserver>();

        public Form1()
        {
            InitializeComponent();

            //생성자에서 registerObserver를 호출함
            //즉 frm2를 집어넣게 되는 거
            Form2 frm2 = new Form2(this); //Form2(ISubject sub)
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;//배치
            panel1.Controls.Add(frm2);
            frm2.Show();

            Form3 frm3 = new Form3(this); //Form3(ISubject sub)
            frm3.TopLevel = false;
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.Dock = DockStyle.Fill;//배치
            panel2.Controls.Add(frm3);
            frm3.Show();

            Form4 frm4 = new Form4(this, frm2, frm3);
            frm4.TopLevel = false;
            frm4.FormBorderStyle = FormBorderStyle.None;
            frm4.Dock = DockStyle.Fill;
            panel3.Controls.Add(frm4);
            frm4.Show();


        }

        public void notifyObserver()
        {
            foreach (IObserver item in _observers)
            {
                item.update(textBox1.Text);
            }
        }

        public void registerObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void unregisterObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                notifyObserver(); //텍스트박스에 엔터를 치면
                //notifyObserver 호출
                //이 기능은 _observers에 있는 객체들이 일괄적으로
                //update() 호출하게 함
            }
        }
    }
}
