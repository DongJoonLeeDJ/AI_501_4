using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharpChap07_02
{
    //일종의 자료형
    //숫자(정수)를 좀 더 가독성있게 표현하는 방법
    //열거형
    //단순히 0, 100, 101 이렇게 하거나
    //상수를 쓸 수도 있지만
    //0=ON, 100=Idle(ON도 아니고 OFF도 아닌 상태), OFF=101
    //이렇게 정의하는 걸 여러군데서 공통적으로 쓸 경우

    //상수 모음집
    enum MachineState //기계 상태
    {
        ON, Idle = 100, OFF
    }
    //ON에는 아무것도 적지 않았으므로 0이 들어가 있다.
    //Idle을 100일고 정의했으므로 OFF는 자동으로 101이다.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("메시지 박스 내용", "메시지 박스 제목", MessageBoxButtons.YesNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            a.Eat();
            a.Sleep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            d.Eat();
            d.Sleep();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Eat();
            c.Sleep();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Animal d = new Dog();
            d.Eat();
            d.Sleep(); 
            (d as Dog).Sleep(); 

            (d as Animal).Eat(); //조상클래스로 강제 형변환 후 메소드 호출
            (d as Animal).Sleep();//여기에서 하이딩과 오버라이딩의 차이가 드러남

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal c = new Cat();
            c.Eat();
            c.Sleep();

            (c as Animal).Eat(); //조상클래스로 강제 형변환 후 메소드 호출
            (c as Animal).Sleep();//여기에서 하이딩과 오버라이딩의 차이가 드러남
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            Cat c = new Cat();

            (d as Animal).Eat(); //Animal로 형변환을 해도, Dog, Cat에 override 된 메소드가 호출됨
            (c as Animal).Eat();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            Cat c = new Cat();
            (d as Animal).Sleep();  //하이딩된 건 Animal로 형변환하게 되면 Animal에 있는 메소드를 호출함
            (c as Animal).Sleep();  //원래 Dog, Cat에 있던 Sleep 말고...
        }

        MachineState myState;

        private void button8_Click(object sender, EventArgs e)
        {
            myState = MachineState.ON;
            MessageBox.Show("기계 상태 : " + MachineState.ON);
            MessageBox.Show("기계 상태 : " + (int)MachineState.ON);
            MessageBox.Show("기계 상태 : " + (MachineState)0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myState = MachineState.Idle;
            MessageBox.Show("기계 상태 : " + MachineState.Idle);
            MessageBox.Show("기계 상태 : " + (int)MachineState.Idle);
            MessageBox.Show("기계 상태 : " + (MachineState)100);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myState = MachineState.OFF;
            MessageBox.Show("기계 상태 : " + MachineState.OFF);
            MessageBox.Show("기계 상태 : " + (int)MachineState.OFF);
            MessageBox.Show("기계 상태 : " + (MachineState)101);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            MessageBox.Show("기계 상태 : " + myState);
            MessageBox.Show("기계 상태 : " + (int)myState);
        }
    }
}
