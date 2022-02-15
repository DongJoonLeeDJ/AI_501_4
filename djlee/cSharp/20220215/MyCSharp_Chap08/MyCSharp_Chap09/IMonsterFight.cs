using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap09
{
    public interface IMonsterFight : IFight
    {
        //IFight가 가지고 있는 Attack도 가지고 있음

        void MagicArrow();
        void PhysicalAttack();
    }
}
