using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap09
{
    public abstract class LOL //LOL이라는 클래스를 상속받았다면 BornVoice와 DieVoice를 구현해야 함
    {
        public string name { get; set; } //이름
        public string race { get; set; } //종족

        public abstract void BornVoice(); //캐릭터 생성할 때 내는 소리
        public abstract void DieVoice(); //캐릭터 죽을 때 내는 소리
    }
}
