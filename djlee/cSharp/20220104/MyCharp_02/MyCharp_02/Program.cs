using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCharp_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕하세요.");
            //while (true) { }

            //Console.ReadLine() = 입력
            //Console.WriteLine() = 출력
            //입력한 걸 그대로 출력하게 함.
            Console.WriteLine(Console.ReadLine());
            //nextInt
            int a = int.Parse(Console.ReadLine()); //정수를 입력받는 방법1
            
            int.TryParse(Console.ReadLine(), out a);//정수를 입력받는 방법2

            int.TryParse(Console.ReadLine(), out int b); //정수 입력받는 방법3

            string myname = Console.ReadLine();

            string name = Console.ReadLine();

            //cr
            Console.ReadLine();
            //intcr
            int.Parse(Console.ReadLine());
            //tryint
            int.TryParse(Console.ReadLine(), out int ex);
        }
    }
}
