using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_20220105
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Inch 단위를 입력 받아 cm 단위를 구하는 코드를 작성하시오.
            //1inch = 2.54cm
            Console.WriteLine("몇 인치?");
            int myinch = int.Parse(Console.ReadLine());
            Console.WriteLine($"{myinch}inch = {myinch*2.54}cm");

            /*
             킬로그램(kg) 단위를 입력받아 파운드(pound)단위를 
            구하는 코드를 작성하시오.
            1kg = 2.20462262pound
             */
            Console.WriteLine("몇 kg?");
            int mykg = int.Parse(Console.ReadLine());
            //const = 상수
            const double POUND = 2.20462262;
            //Console.WriteLine($"{mykg}kg = {mykg*POUND}pound");
            int ct = Console.CursorTop;
            int cl = Console.CursorLeft;
            Console.SetCursorPosition(cl + mykg.ToString().Length, ct - 1);
            Console.WriteLine($"kg = {mykg*POUND}pound");

            const double PI = 3.14;
            Console.WriteLine("원의 반지름 입력받아 원의 둘레와 넓이 구하기");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"둘레 = {2*PI*r}");
            Console.WriteLine($"넓이 = {PI*r*r}");

            //둘 다 숫자로써 계산
            //두 번째 숫자를 %10, /10하고 %10, /100 이런식으로 
            //첫번째, 두번째, 세번째 자리를 구한다.
            Console.WriteLine("첫 번째 숫자를 입력해주세요.");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력해주세요.");
            int second = int.Parse(Console.ReadLine());

            //ctrl+d 하면 라인 복사 & 붙여넣기
            //ctrl+x 잘라내기인데, 보통 한 줄 통째로 삭제하고 싶을 때 씁니다.
            //alt+ctrl = 여러개를 마우스로 선택
            //alt+shift+방향키(위아래) : 여러개를 키보드로 선택 가능
            Console.WriteLine($"{first*(second%10)}");
            Console.WriteLine($"{first*((second/10)%10)}");
            Console.WriteLine($"{first*(second / 100)}");
            Console.WriteLine($"{first*second}");

            //두번째 숫자를 문자열로 인식하고 배열 연산 이용해서 각 자리에 있는
            //숫자를 가져와서 계산하기
            //1. 아스키코드 이용
            string str_second = second.ToString();
            //'0'을 빼는 이유는... str_second[0], str_second[1], str_second[2]는
            //글자이고, 글자는 아스키코드값을 가진다.
            //'0'은 숫자 48로 대응되고, '9'는 숫자 57로 대응됨
            Console.WriteLine($"{first*(str_second[2]-'0')}");
            Console.WriteLine($"{first*(str_second[1]-'0')}");
            Console.WriteLine($"{first*(str_second[0]-'0')}");
            //Char.GetNumericValue = 글자를 숫자로 바꿔주는 방법
            Console.WriteLine($"{first*Char.GetNumericValue(str_second[0])}");
            //2. tostring과 parse 이용하기
            Console.WriteLine($"{first * int.Parse(str_second[2].ToString())}");
            Console.WriteLine($"{first * int.Parse(str_second[1].ToString())}");
            Console.WriteLine($"{first * int.Parse(str_second[0].ToString())}");


        }
    }
}
