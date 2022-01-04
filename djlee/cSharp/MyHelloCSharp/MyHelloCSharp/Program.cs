using System; //java의 import... 라이브러리 가져다 쓰기 위한 것, C 언어의 헤더파일
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelloCSharp //프로그램 이름 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cw 입력하고 tab 키 두 번 누름
            Console.WriteLine("안녕"); //System.out.println("안녕");   printf("안녕\n");
            Console.WriteLine("하세요.");
            Console.Write("Hello "); //System.out.print("Hello "); printf("안녕");
            Console.Write("World\n");

            Console.WriteLine("문제 풀이");
            Console.Write("Write");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.Write("Write");
            Console.WriteLine("Write");
        }
    }
}
