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
        }
    }
}
