using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp03_Last_Console
{
    //JamMin 클래스는 Student를 상속받음
    //즉 Student의 속성이랑 메소드를 다 쓸 수 있는 상태
    public class JamMin : Student
    {

        //Student처럼 처음에 선언할 때
        //모든 속성에 값을 넣고 싶다면
        //아래와 같은 코드를 추가해야 함
        //base = Student = 조상클래스
        //base(id, name, age, number) : 조상 클래스의 그 생성자를 그대로 갖다쓰는 거
        public JamMin(int id, string name, int age, int number) : base(id, name, age, number)
        {
        }

        //Name, Age, Id, Number가 있다.
        //DoStudy도 있다.
        public void DoPlay()
        {
            Console.WriteLine(Name+"은 하라는 공부는 안 하고 게임한다.");
            Console.WriteLine("나이는 겨우 "+Age+"살이다.");
        }
    }
}
