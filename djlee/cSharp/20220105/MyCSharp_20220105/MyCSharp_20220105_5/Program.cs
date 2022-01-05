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

            if (false)
            {
                string input = Console.ReadLine();
                //input = "exit";
                while (input != "exit")
                {
                    Console.WriteLine("안녕하세요. 당신의 이름은?");
                    input = Console.ReadLine();
                    Console.WriteLine($"{input}님 안녕하세요.");
                }
            }

            if(false)
            {
                Console.WriteLine("goto문으로 인한 이동");
                int count = 0;
                do //한 번은 무조건 실행
                {
                    count++;
                    Console.WriteLine("숫자 입력해보세요.");
                    count = int.Parse(Console.ReadLine());
                } while (count != 0); //count가 0이면 끝나는 조건임...
            }


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
                    continue; //continue 키워드
                              //밑에꺼는 더이상 수행 안하고
                              //다음단계로 넘어가버림
                sum += i; //홀수가 아닌 경우 즉 짝수인 경우엔 더한다.
            }
            Console.WriteLine("sum(짝수)="+sum);


            //foreach
            //for(int item : arr) java
            int[] myarr = new int[5];
            myarr[0] = 10;
            myarr[1] = 15;
            myarr[2] = 100;
            myarr[3] = 29;
            myarr[4] = 34;
            //myarr에 있는 값에 접근해서, 값들 출력하고'
            //여기 있는 값들을 더해서 새로운 숫자를 만들고 싶다면?
            
            //foreach : 배열이나 List에 있는 각각의 값들에 접근해주고,
            //배열의 길이만큼 반복해주는 반복문
            sum = 0;
            Console.WriteLine("foreach문 활용해보기");
            //js의 var와 다른 점
            //js에서 var는 변수의 타입이 정해져 있지 않다.
            //하지만 c#에선 한 번 타입을 정하면 그 타입으로 쭉 간다.
            var mytest = 100; //mytest라는 변수는 100이 들어갔으므로 int타입
            foreach (var item in myarr)
            {
                sum +=item;
                Console.WriteLine("item = "+item);
            }
            Console.WriteLine("sum="+sum);
            sum = 0;
            Console.WriteLine("for문 활용");
            for(int i = 0; i < myarr.Length; i++)
            {
                sum += myarr[i];
                Console.WriteLine($"myarr[{i}]={myarr[i]}");
            }
            Console.WriteLine("sum="+sum);

            foreach (var item in myarr)
            {
                //item = 0; //값 할당 자체가 안 됨...
                //foreach는 읽어들이는 데 적당함

                //for문은 읽고, 쓰고, 인덱스별 접근까지 다 됨
            }

            int testcount = 0;
            while (true)
            {
                testcount++;
                if (testcount > 100)
                    goto mytest;

            }

            Console.WriteLine("안녕히 가세요.");
            mytest:
                Console.WriteLine("여기로 순간이동했어요");
        }
    }
}
