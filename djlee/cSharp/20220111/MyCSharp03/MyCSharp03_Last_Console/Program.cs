using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp03_Last_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Name = "마티즈";
            c.Description = "토스에 조회해보니 0원";
            c.price = 0;
            c.quantity = -100;
            Console.WriteLine(c.quantity);
            c.quantity = 100;
            Console.WriteLine(c.quantity) ;
        }
    }
}
