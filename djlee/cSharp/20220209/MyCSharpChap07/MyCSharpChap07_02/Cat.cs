using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpChap07_02
{
    public class Cat : Animal
    {
        public double number { get; set; } // 하이딩은 new 키워드를 안 적어도 되긴 한데, 녹색줄(=경고) 뜬다.

        public void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("집사야 잠자리가 불편하다~ 턱이 간지럽구나~");
        }

        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("집사야 참치통조림이 좀 짜다~");
            //base.Eat();
        }

    }
}
