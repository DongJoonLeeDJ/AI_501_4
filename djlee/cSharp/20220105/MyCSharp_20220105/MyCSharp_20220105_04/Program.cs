using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_20220105_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("nums의 길이 = " + nums.Length);
            int[] numarr = new int[10];
            //int[] long_num_arr = new int[int.MaxValue];
            Console.WriteLine("numarr의 길이 = " + numarr.Length);
            //Console.WriteLine("long_num_arr 길이 = " + long_num_arr.Length);

            //2차원 배열
            int[,] num2dim = { { 1, 2, 3 }, { 4, 5, 6 } }; //2행 3열
            num2dim[0, 0] = 1000; //값 쓰기
            Console.WriteLine(num2dim[0,0]); //값 읽어들이기
            int[,] num2dim2 = new int[2, 3]; //2행 3열

            //동적 배열... 배열의 크기를 입력받아서 결정한다.
            Console.WriteLine("배열의 크기?");
            int size = int.Parse(Console.ReadLine()); 
            int[] my_size_arr = new int[size];
            Console.WriteLine("my_size_arr의 길이 = "+my_size_arr.Length);
        }
    }
}
