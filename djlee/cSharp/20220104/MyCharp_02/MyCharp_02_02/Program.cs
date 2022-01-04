using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCharp_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             
            //string test = Console.ReadLine();
            //int ct = Console.CursorTop;
            //int cl = Console.CursorLeft;
            //Console.SetCursorPosition(cl + test.Length, ct-1);
            //참고
            //Console.ReadLine한 다음 커서 움직이는 거
             
             




            // \ (역슬래시) = escapse 문자
            //폰트따라선 W 모양으로 나오기도 함
            Console.WriteLine("내 이름은 \"이동준\"입니다.");
            Console.WriteLine("\\"); // escape 문자 자체를 출력
            Console.WriteLine(@"이동준\류경문");//앞에 @ 붙이면 역슬래시(escape문자)에 한해선 두 번 안 적어도 됨

            Console.WriteLine("Hello World"[0]);
            Console.WriteLine("안녕하세요"[0]);            
            Console.WriteLine("Hello World"[1]);
            Console.WriteLine("안녕하세요"[1]);            
            Console.WriteLine("Hello World"[2]);
            Console.WriteLine("안녕하세요"[2]);
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //ctrl누르고 k 누르고 c 누름
            //ctrl 누르고 k 누르고 u 누르면 주석 해제
            //Console.WriteLine(a + b);   
            Console.WriteLine("원주율은?");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("이름은?");
            string s = Console.ReadLine();
            //ctrl +k, f - 정렬
            //문자열 조합하는 방식
            //원의 넓이는 d입니다.
            //내 이름은 이동준입니다.
            Console.WriteLine("원주율은 " + d + "입니다.");
            Console.WriteLine(string.Format("원주율은 {0}이고, 내 이름은 {1}입니다.", d, s));
            Console.WriteLine($"원주율은 {d}이고, 이름은 {s}입니다."); //js의 `${} ${}` 방식



            Console.WriteLine("문자 입력해보세요.");
            char c = Console.ReadLine()[0]; //이건 문자열인데 문자열의 가장 첫번째껄 반환해준다.
            Console.WriteLine("c="+c);


        }
    }
}
