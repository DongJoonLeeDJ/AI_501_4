using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_20220105_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            while(input != "exit")
            {
                Console.WriteLine("안녕하세요. 당신의 이름은?");
                input = Console.ReadLine();
                Console.WriteLine($"{input}님 안녕하세요.");
            }

            int count = 0;
            do
            {
                count++;
                Console.WriteLine("숫자 입력해보세요.");
                count = int.Parse(Console.ReadLine());
            } while (count != 0); //count가 0이면 끝나는 조건임...


            //유니코드상 한글은 '가'부터 시작해서
            //'힣'에서 끝남...
            //즉 모든 한글을 다 출력한 거...
            //for(char a = '가'; a<='힣'; a++)
            //{
            //    Console.Write(a);
            //}
            Console.WriteLine(); //아무것도 안 적으면 그냥 한 줄을 띄어준다.
            //1부터 100까지의 합
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine("sum="+sum);

            //반복문에서 나오는 키워드 : break와 continue
            sum = 0;
            int mycount = 1;
            while (true)
            {
                sum += mycount;
                if (mycount == 100)
                    break; //반복문 종료
                mycount++;
            }
            Console.WriteLine("sum="+sum);

            //짝수인 경우만 더해보자.(1부터 10까지)
            sum = 0;
            for(int i = 1; i<=10; i++)
            {
                if (i % 2 != 0) //홀수인 경우
                    continue;
                sum += i; //홀수가 아닌 경우 즉 짝수인 경우엔 더한다.
            }
            Console.WriteLine("sum(짝수)="+sum);
        }
    }
}
