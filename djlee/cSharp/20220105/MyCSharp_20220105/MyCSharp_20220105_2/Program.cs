using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_20220105_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testnum = 100;
            if(testnum > 50)
            {
                Console.WriteLine("testnum은 50을 넘는다.");
            }

            if(testnum < 0 )
            {
                Console.WriteLine("testnum은 음수");
            }
            else
            {
                Console.WriteLine("testnum은 양수");
            }

            if(testnum == 10)
            {
                Console.WriteLine("testnum은 10이다.");
            }
            else if(testnum == 100)
            {
                Console.WriteLine("testnum은 100이다.!!!");
            }
            else
            {
                Console.WriteLine($"testnum은 {testnum}이다.");
            }


            Console.WriteLine("나이를 입력해주세요.");
            int age = int.Parse(Console.ReadLine());
            if(age < 0 || age > 123 )
                Console.WriteLine("타노스");
            else if(age>=0 && age<20)
                Console.WriteLine("미성년자");
            else if(age<40)//else if(age>=20 && age <40)
                Console.WriteLine("청년");
            else if(age<60)
                Console.WriteLine("중년");
            else if(age<100)
                Console.WriteLine("노년");
            else if(age<=123)
                Console.WriteLine("장수");
            //else
            //{

            //}

        }
    }
}
