using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp04_00_List
{
    public class Product
    {
        //static이 붙는 것들을 '클래스 변수', '클래스 메소드'(혹은 클래스함수라고도 함)
        //static 붙은 건... 인스턴스들이 '공통으로' 갖는 기능, 변수이다.

        public static int pCount = 0; //제품의 개수
        public Product()
        {
            pCount++; //인스턴스 생성시마다(=제품 추가마다) 값이 늘어남.
        }
        public static int showCount()
        {
            return pCount;
        }

        //인스턴스 변수들
        //객체별로 각자 다른 값을 가질 수 있다.
        public string name { get; set; }
        public int price { get; set; }

        //인스턴스 메소드
        //객체 별로 각자 다른 반환값, 다른 명령을 수행할 수 있다.
        public void introduce()
        {
            //mbox 탭탭
            System.Windows.Forms.MessageBox.Show($"이 제품명은 {name}, 가격은 {price}원입니다.");
        }
    }
}
