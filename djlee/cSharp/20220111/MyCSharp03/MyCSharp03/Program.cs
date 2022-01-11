using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 입력시 1출력      - 0+1
            //2~7입력시 2출력     - 6+1까지
            //8~19입력시 3출력    - 12+7까지
            //20~37 입력시 4출력  - 18+19까지
            //36~61 입력시 5출력  - 24+37까지
            Console.WriteLine("숫자를 입력하세요.");
            int input = int.Parse(Console.ReadLine());
            int max = 1; //각 벌집의 최댓값
            int counter = 0; //임의의 카운트 변수
            while (true)
            {
                max = max + (6 * counter);
                if(max<input)
                {
                    counter++;
                    continue;
                }
                else
                    Console.WriteLine($"{input}은/는 {counter+1}번째 벌집에 속함");
                break;
            }
        }
    }
}
