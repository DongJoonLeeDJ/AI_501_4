using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp03_Last_Console
{
    public class Car
    {
        /*
         * 
         *
        //이걸 기본 생성자라고 함
        //기본 생성자엔 아무것도 없음
        //이게 암묵적으로 만들어져 있기 때문에
        //Car c = new Car(); 코드가 되는 것이다.
        public Car()
        {
        }
         
         
         */




        // { get; set; } 의 의미
        //java의 getter, setter랑 똑같은 거
        //java의 통상적 getter, setter랑 똑같이 쓸거면 그냥 {get;set;}쓰거나
        //혹은... 생략을 해도 당장 큰 문제 없다.
        public string Name { get; set; }    //자동차 이름
        public string Description { get; set; } //자동차에 대한 설명

        //get;set;을 생략해도 당장은 문제 없다.
        //하지만 나중에 dataGridView(엑셀의 표처럼 생긴 거)랑
        //클래스 연결할 때 {get; set;} 꼭 필요함!
        public int price; //자동차 가격
        
        //getter와 setter에 별도의 코드들을 집어넣고 싶다면
        //별도의 private 변수 선언하고
        //그 변수를 리턴하거나 그 변수의 값을 바꾸는 식으로 코드를 짜야한다.(아래처럼)
        private int q;
        public int quantity //quantity를 통해 q에 접근하는 거임. q 대신 quantity 대입하면 stackoverflow
        {
            get { return q; }
            set {
                if (value < 0)
                {
                    //Console.WriteLine($"{value}는 음수입니다!!!");
                    q = 0;
                }
                else
                    q = value;
            }
        }
    }
}
