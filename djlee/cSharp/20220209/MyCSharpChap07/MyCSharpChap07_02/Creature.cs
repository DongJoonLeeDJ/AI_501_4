using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpChap07_02
{
    //Creature 자체는 인스턴스 생성할 수 없다.
    //Create c = new Createture();
    //대신... 이걸 상속받은 클래스들은 반드시 Born, Die 기능을 구체화(=구현)시켜야 한다!!!
    public abstract class Creature
    {
        abstract public void Born();
        abstract public void Die();
    }
}
