using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpChap07
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        

        public Animal()
        {
            Age = 0;
        }

        //protected : 상속받은 클래스만 접근이 가능함
        protected void Run()
        {
            System.Windows.Forms.MessageBox.Show(Name+"이/가 달립니다!!!");
        }

        public void Eat()
        {
            Console.WriteLine(Name+ "이 촵촵 먹는다.");
            System.Windows.Forms.MessageBox.Show(Name + "이 촵촵 먹는다.");
        }
        public void Sleep()
        {
            Console.WriteLine(Name+"이 잠을 잔다. zZZ...");
            System.Windows.Forms.MessageBox.Show(Name + "이 잠을 잔다. zZZ...");
        }

    }
}
