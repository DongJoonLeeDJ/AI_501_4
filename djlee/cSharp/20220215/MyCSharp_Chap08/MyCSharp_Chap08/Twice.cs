using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap08
{
    public class Twice
    {
        public int this[int i]
        {
            get { return i*2; }
            set { System.Windows.Forms.MessageBox.Show(i+"값을 set함.(실제로 반영 안 됨)"); }
        }
    }
}
