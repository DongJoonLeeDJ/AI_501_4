using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpChap07_02
{
    public class Dog : Animal
    {
        //하이딩
        public new int number { get; set; } //Animal과는 다르게 number 속성이 int이다.

        //하이딩
        public new void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("주인님 잠을 재워주셔서 감사합니다.");
        }

        //오버라이딩
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("멍멍촵촵 멍멍촵촵");
            //base.Eat(); //조상클래스의 Eat을 그대로 호출한다.
        }
    }
}
