using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap10
{
    //이 인터페이스를 구현한(=상속한) 객체는 반드시 update메소드가 구현이 되어 있어야 한다.
    //IObserver List가 있다면 이 update 메소드가 구현된 객체들만 있는 것이다.
    public interface IObserver
    {
        void update(string value);
    }
}
