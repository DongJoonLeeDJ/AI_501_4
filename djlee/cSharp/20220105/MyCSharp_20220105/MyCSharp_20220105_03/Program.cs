using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_20220105_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //region 영역
            #region MyIfStatementTest
            //alt + 방향키(위,아래) : 코드 이동함
            bool flag = false;
            /*<-눌러*/
            if (flag) //flag 값을 false로 두면 이 중괄호 안에 있는 것들 다 실행x
            {
                //switch문
                char hakjeom = 'A';
                switch (hakjeom)
                {
                    case 'A'://case 밑에 뭔가 한 줄이라도 있으면 break로 끝내야 함
                        Console.WriteLine("엘리트");
                        break;
                    case 'B':
                        Console.WriteLine("나쁘진않음");
                        break;
                    case 'C': //case 밑에 하나도 없는 경우에만 이렇게 쓸 수 있음
                    case 'D':
                        Console.WriteLine("좀 문제있음");
                        break;
                    case 'F':
                        Console.WriteLine("ㅠㅠ");
                        break;
                    default:
                        Console.WriteLine($"{hakjeom}은 유효하지 않습니다.");
                        break;
                }
                //삼항 연산자
                //if나 switch문보다 간단하게 쓸 수 있는 연산자
                //근데 if나 switch에 익숙한 사람이 보면 조금 난해할 수 있음
                //나는 안 쓰더라도 이걸 쓰는 사람은 꼭 1명쯤은 있다.

                int mynumber = 100;
                //mynumber를 2로 나눠서 0인 경우(=짝수)
                //result 변수에 "짝수" 대입
                //그게 아닌 경우(=홀수) "홀수" 대입

                //(참거짓을판별할식) ? (그 식이 참인 경우) : (그 식이 거짓인 경우)
                string result = mynumber % 2 == 0 ? "짝수" : "홀수";
                Console.WriteLine(result);
                Console.WriteLine(mynumber % 2 == 0 ? "짝수" : "홀수");

                string Hello = "Hello World";
                bool t1 = Hello.Contains("Hell");
                bool t2 = Hello.Contains("HELL");
                Console.WriteLine("t1=" + t1);
                Console.WriteLine("t2=" + t2);

            }
            #endregion


            #region solve
            int nowYear = DateTime.Now.Year; //2022
            int nowMonth = DateTime.Now.Month; //1

            Console.WriteLine("올해의 띠는?");
            switch (nowYear%12)
            {
                case 9:
                    Console.WriteLine("뱀");
                    break;
                case 10:
                    Console.WriteLine("말");
                    break;
                case 11:
                    Console.WriteLine("양");
                    break;
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭");
                    break;
                case 2:
                    Console.WriteLine("개");
                    break;
                case 3:
                    Console.WriteLine("돼지");
                    break;
                case 4:
                    Console.WriteLine("쥐");
                    break;
                case 5:
                    Console.WriteLine("소");
                    break;
                case 6:
                    Console.WriteLine("호랑이");
                    break;
                case 7:
                    Console.WriteLine("토끼");
                    break;
                case 8:
                    Console.WriteLine("용");
                    break;
                default:
                    break;
            }

            switch (nowMonth)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                default:
                    Console.WriteLine($"{nowMonth}는 잘못됐습니다.");
                    break;
            }


            #endregion

        }
    }
}
