using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp03_Last_Console
{
    public class Student
    {
        //기본 생성자를 삽입해주면
        //Student s = new Student(); 
        //이게 된다.

        public Student()
        {

        }

        //만약에 학생의 id랑 이름만 알고, 나이랑 번호를 모른다면?
        public Student(int id, string name)
        {
            //this 키워드
            //클래스의 멤버를 가리킨다는 의미!
            this.Id = id;
            this.Name = name;
        }

        public Student(int id, string name, int age, int number)
        {
            Id = id;
            Name = name;
            Age = age;
            Number = number;
        }

        public int Id { get; set; } 
        public string Name { get; set; }    
        
        public int Age { get; set; }

        public int Number { get; set; }

        public void DoStudy()
        {
            Console.WriteLine(Name+"은 열심히 공부하고 있습니다.");
        }
    }
}
