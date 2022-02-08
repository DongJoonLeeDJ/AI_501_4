using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_from_06
{
    //어떤 A라는 학교의 학생을 관리하는 프로그램에서의 Student 클래스
    public class Student
    {
        /// <summary>
        /// 클래스 파트
        /// </summary>

        //학교의 모토(=교훈)
        //모든 학생들의 공통적으로 갖는 값
        public static string Motto { get; set; } //클래스 변수
        //학교의 학생 수.
        //학생별로 다르지 않고 다 똑같은 값.
        public static int Count { get; set; } // 클래스 변수

        //학생 추가할 때 마다 인원수는 증가
        public Student()
        {
            Count++;
        }
        //생성함과 동시에 멤버변수 값을 할당할 수 있음
        public Student(string Name, string Hakbeon)
        {
            this.Name = Name;
            this.Hakbeon = Hakbeon;
            Count++;
        }
        //만약 학생의 학번은 모르고 이름만 우선 등록했다면...
        public Student(string Name)
        {
            this.Name =Name;
            Count++;
        }


        //"학생"의 정체성
        //학생들이 공통적으로 수행하는 기능
        public static void DoStudy() //클래스 메소드
        {
            Console.WriteLine("공부하는 중이에요.");
        }


        /// <summary>
        /// 인스턴스 파트
        /// </summary>
        public string Name { get; set; }
        public string Hakbeon { get; set; }
        //인스턴스 별로 메소드 다르게 호출함
        public void introduceSelf() //오버로딩: 리턴타입은 중요하지 않고 매개변수가 중요!
        {                           //오버로딩 : 매개변수 개수 혹은 매개변수의 타입이 다르면
                                    //메소드 이름이 같아도 다른 걸로 취급됨(java, c++ ok, c에선 없음)
            Console.WriteLine("내 이름은 " + Name + "이다.");
        }
        public void introduceSelf(int score)
        {
            Console.WriteLine("학번 : " + Hakbeon);
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("점수 : " + score);
        }
    }
}
