using System;
using System.Collections.Generic;
using System.Data;
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
            try
            {
                DBHelper.selectQuery();
                Cars.Clear(); //db에서 새로 받아오기
                foreach(DataRow item in DBHelper.ds.Tables[0].Rows) //select의 결과값을 받아옴
                {
                    ParkingCar tempCar = new ParkingCar();
                    tempCar.ParkingSpot = int.Parse(item["parkingSpot"].ToString());
                    tempCar.CarNumber = item["CarNumber"].ToString();
                    tempCar.DriverName = item["driverName"].ToString();
                    tempCar.PhoneNumber = item["PhoneNumber"].ToString();
                    //ParkingTime이 null일 경우 new DateTime()을 넣음
                    //new DateTime()은 0000년 01월... 이런 초기값임
                    tempCar.ParkingTime = item["ParkingTime"].ToString() == "" ?
                        new DateTime() : DateTime.Parse(item["parkingTime"].ToString());
                    Cars.Add(tempCar);

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                PrintLog(ex.StackTrace);
            }
        }
        public static void Save
            (int parkingSpot, string carNumber, string driverName, string phoneNumber, bool isRemove=false) //주차 출차때 주로 사용됨
        {
            try
            {
                DBHelper.updateQuery(parkingSpot, carNumber, driverName, phoneNumber, isRemove);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                PrintLog(ex.StackTrace);
            }
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
