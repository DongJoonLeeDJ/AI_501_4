using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_from_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //프로그램 처음 시작시 지정할 수 있고,
            //어느 한 곳에서 바꾸게 되면
            //다 바뀐다.
            Student.Motto = "배워서 남 주자";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            Student student = new Student();
            student.Name = textBox1.Text;
            student.introduceSelf();

            //인스턴스를 생성하지 않아도 됨.
            Student.DoStudy();//모든 학생들이 공통적으로 하는 것
            Console.WriteLine(Student.Motto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = textBox2.Text;
            student.introduceSelf();

            Student.DoStudy();//모든 학생들이 공통적으로 하는 것
            Console.WriteLine(Student.Motto);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                button2.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            s1.Name = textBox3.Text;
            s2.Name = textBox4.Text;

            s1.introduceSelf();
            s2.introduceSelf();

            Console.WriteLine(s1==s2);

            Student.DoStudy();//모든 학생들이 공통적으로 하는 것
            Console.WriteLine(Student.Motto);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("학생 수 = " + Student.Count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Student.Motto = textBox5.Text;
            Console.WriteLine(Student.Motto);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBox6.Text;
            s.Hakbeon = textBox7.Text;
            int score = int.Parse(textBox8.Text);
            s.introduceSelf(score);
            s.introduceSelf();
        }
    }
}
