using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap08
{
    public class MySquare
    {
        public int this[int i]
        {
            get { return i*i; }
        }
    }
}
