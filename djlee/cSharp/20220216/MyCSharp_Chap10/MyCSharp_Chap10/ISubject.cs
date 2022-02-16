using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap10
{
    //Oberser로 등록된(IObserver List) 객체들에게 일괄적으로 IObserver에 있는 메소드를 호출하게 하고(=통지하다)
    //이 리스트에 특정 객체를 추가하거나(=subscribe 혹은 register. 구독 혹은 등록)
    //삭제한다.(=dissubscribe 혹은 unregister)
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void unregisterObserver(IObserver o);
        void notifyObserver();
    }
}
