using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharpChap07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            a.Name = textBox1.Text;
            MessageBox.Show("이 동물의 이름은 " + a.Name + "이고, 나이는 " + a.Age + "이다.");
            a.Age = int.Parse(textBox2.Text);
            MessageBox.Show("이 동물의 이름은 " + a.Name + "이고, 나이는 " + a.Age + "이다.");
            a.Eat();
            a.Sleep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            d.Name = textBox1.Text;
            MessageBox.Show("이 동물의 이름은 " + d.Name + "이고, 나이는 " + d.Age + "이다.");
            d.Age = int.Parse(textBox2.Text);
            MessageBox.Show("이 동물의 이름은 " + d.Name + "이고, 나이는 " + d.Age + "이다.");
            d.Color = textBox3.Text;
            MessageBox.Show("이 동물의 이름은 " + d.Name + "이고, 나이는 " + d.Age + "이다." + " 털 색은 " + d.Color + "이다.");
            d.Eat();
            d.Sleep();
            d.Bark();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cat d = new Cat();
            d.Name = textBox1.Text;
            MessageBox.Show("이 동물의 이름은 " + d.Name + "이고, 나이는 " + d.Age + "이다.");
            d.Age = int.Parse(textBox2.Text);
            MessageBox.Show("이 동물의 이름은 " + d.Name + "이고, 나이는 " + d.Age + "이다.");
            d.eyeColor = textBox4.Text;
            MessageBox.Show("이 동물의 이름은 " + d.Name + "이고, 나이는 " + d.Age + "이다." + " 눈 색은 " + d.eyeColor + "이다.");
            d.Eat();
            d.Sleep();
            d.Meow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            MessageBox.Show("이 동물의 이름은 " + d.Name + "이고, 나이는 " + d.Age + "이다." + " 털 색은 " + d.Color + "이다.");
            d.Bark(); //짖고 달린다.
            //d.Run(); Form1자체가 Animal을 상속한 게 아니므로, Run 호출 불가능
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();//기존창 감춤
            new Form2().ShowDialog(); //.Show();
            //코드가 여기서 멈춰있음(모달 = Modal)
            //이 창이 띄워진 시점에선 뒤에 창 건드리지 못함.
            //Show() 하면 창이 2개가 나타남 : Show 모달리스(Modeless)
            Show();//감춘 창을 나타냄.
        }
    }
}
