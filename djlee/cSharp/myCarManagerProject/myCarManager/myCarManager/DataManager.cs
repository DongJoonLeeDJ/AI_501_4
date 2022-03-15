using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCarManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();

        static DataManager()
        {
            Load();
        }

        public static void Load() //DB에서 주차데이터들 불러올 때
        {
        }
        public static void Save() //주차 출차때 주로 사용됨
        {
        }
        public static void PrintLog(string contents) //기록을 적을 때 사용됨
        {
            //폴더 명이 ParkingHistory인 것을 찾는 중
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");

            if(!di.Exists) //폴더가 없으면 폴더를 만든다.
            {
                di.Create();
            }

            //ParkingHistory 폴더에
            //ParkingHistory.txt 파일에 (string contents) 내용을 적는다.
            //끝에 true = append 옵션인데, 이게 없으면 새로운 내용이 나와도 계속 덮어써버림
            //즉 새로운 내용이 계속 이어지지 않습니다.
            using (StreamWriter Writer = new StreamWriter("ParkingHistory\\ParkingHistory.txt", true))
            {
                Writer.WriteLine(contents);
            }
        }

    }
}
