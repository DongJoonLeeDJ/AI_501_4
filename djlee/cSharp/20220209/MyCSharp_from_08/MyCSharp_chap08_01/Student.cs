using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_chap08_01
{
    //Generic
    //T : int, double, char, String, 심지어 또 다른 클래스 등이 올 수 있다.
    public class Student<T>
    {
        public T Hakbeon { get; set; }
    }
}
