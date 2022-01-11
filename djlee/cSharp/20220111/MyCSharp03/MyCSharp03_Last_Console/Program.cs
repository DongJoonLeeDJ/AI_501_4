using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp03_Last_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("안녕");
            //Main(args);
            //Console.WriteLine("하세요");


            Car c = new Car();
            c.Name = "마티즈";
            c.Description = "토스에 조회해보니 0원";
            c.price = 0;
            c.quantity = -100;
            Console.WriteLine(c.quantity);
            c.quantity = 100;
            Console.WriteLine(c.quantity) ;

            //위의 자동차 c는 일단은 선언하고 나서, 그 뒤에 속성들을 정의함
            //학생 s는 변수 선언과 동시에 Id, 이름, 나이, 번호를 정의함
            Student s = new Student(111, "이동준", 34, 1);
            Student s2 = new Student();
            //생성자 : 클래스이름()
            //new + 생성자 => 인스턴스
            //인스턴스 : 예시
            s2.Name = "권도균";

            s.DoStudy();
            s2.DoStudy();

            JamMin j = new JamMin(12,"이제영",14,2);
            j.DoStudy();
            j.DoPlay();

        }
    }
}
