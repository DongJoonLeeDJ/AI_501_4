using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Answer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //숫자 5개중에서 최댓값과 최솟값을 찾는 것
            int[] numbers = new int[5];
            for(int i = 0; i< numbers.Length; i++)
            {
                Console.WriteLine("숫자 입력.");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //가장 첫번째 숫자를 최대, 최소로 가정
            //왜냐면 5개의 배열에 똑같은 숫자라 들어갈 수도 있기 때문
            int max = numbers[0];
            int min = numbers[0];
            foreach (var item in numbers)
            {
                if(max < item)
                    max = item;
                if(min > item)
                    min = item;
            }
            Console.WriteLine($"최댓값은 {max}, 최솟값은 {min}입니다.");
            

            string start = "1"; //처음값이자, 결과값 저장해서 출력하는 역할
            for(int i = 0; i<20; i++)
            {
                Console.WriteLine($"{i+1}번째 : {start}");
                string end = ""; //임시 저장소
                char number = start[0]; //내가 읽은 숫자
                int count = 0;//내가 읽은 숫자의 개수
                for(int j = 0; j<start.Length; j++)
                {
                    if(start[j]!=number)//내가 가리키고 있는 숫자가 바뀐 경우
                    { 
                        //내가 가리킨 숫자의 개수랑 그동안 누적된 문장들 저장
                        end = end + number + count;
                        number = start[j];//가리키는 값 변경
                        count = 1;//0이 아니라 1로 초기화하는 이유는 
                    }             //새로운 숫자를 '발견'했기 때문
                    else
                       count++;
                }
                end = end + number + count;
                start = end;
            }

            //end=end+number+count 설명

            //+ 연산의 2가지 역할(java, c#)
            //1+2 하면 3
            //"안녕"+"하세요" = "안녕하세요"
            //""+1+11= 111
            //Console.WriteLine(""+1+11);
            //""+숫자 -> 문자열
            //""+문자 -> 문자열
            //""+문자열 -> 문자열

        }
    }
}
