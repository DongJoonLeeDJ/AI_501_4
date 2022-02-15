using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap09
{
    public class BabyMundo : DrMun, IMonsterFight
    {
        //DrMun에 있던 모~든 메소드들이 다 구현됨(인터페이스들도 다 있음)
        //DrMun에 있는 name, race 속성도 다 있음

        public new void MagicArrow()
        {
            System.Windows.Forms.MessageBox.Show("파이어볼트!");
        }

    }
}
