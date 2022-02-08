using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_from_06
{
    public class Student
    {
        public string Name { get; set; }
        public void introduceSelf()
        {
            Console.WriteLine("내 이름은 " + Name + "이다.");
        }
    }
}
