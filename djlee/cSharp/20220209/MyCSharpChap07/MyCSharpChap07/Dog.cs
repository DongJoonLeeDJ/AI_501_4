using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpChap07
{
    public class Dog : Animal
    {
        public string Color { get; set; }


        //조상클래스인 Animal의 Animal()을 호출하고 (=base())
        //그다음 Color값은 ???가 기본이다.
        public Dog() : base()
        {
            Color = "???";
            Name  =  "?";
        }

        public void Bark()
        {
            Console.WriteLine("멍멍!");
            System.Windows.Forms.MessageBox.Show("멍멍");
            Run();
            //base.Sleep(); //base : 조상클래스. 즉 여기선 Animal됨.
            //근데 지금 시점에선 base 생략해도 됨(뒤에서 오버라이딩 등 나올 때 유용하게 쓰일 예정)

        }
    }
}
