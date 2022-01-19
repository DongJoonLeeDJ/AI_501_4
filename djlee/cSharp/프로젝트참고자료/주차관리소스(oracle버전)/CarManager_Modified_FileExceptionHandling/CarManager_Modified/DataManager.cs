using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace CarManager_Modified
{
    class DataManager
    {

        //결과 데이터 저장하는 곳
        public static List<ParkingCar> parkingCars = new List<ParkingCar>();


        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
       "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
       "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
       "User Id=c##scott;Password=tiger;"; //오라클 연결시 필요한 기본 정보들(id,pw,port 등)
        static OracleConnection OraConn = new OracleConnection();

        public static DataSet ds;

        const string TABLE = "table1";

        private static void ConnectDB()
        {
            try
            {
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void selectQuery()
        {
            ConnectDB(); //db연결 해주고 나서, select문 날리는거다.

            string sql;
            sql = "select * from " + TABLE + " order by to_number(parkingspot)";
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;  //select문 날리는 부분

            ds = new DataSet();
            oda.Fill(ds, TABLE);

            //List<MyTest> tests = new List<MyTest>();

            parkingCars.Clear(); //기존에 있는 걸 지움

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ParkingCar car = new ParkingCar();
                car.ParkingSpot = int.Parse(item["ParkingSpot"].ToString());
                car.CarNumber = item["CarNumber"].ToString();
                car.DriverName = item["DriverName"].ToString();
                car.PhoneNumber = item["PhoneNumber"].ToString();
                car.ParkingTime = item["ParkingTime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());
                parkingCars.Add(car); //그 데이터들을 Cars에 넣음
            }

            OraConn.Close(); //db 연결 닫기

        }
        public static ParkingCar selectQuery(int spot)
        {
            ConnectDB(); //db연결 해주고 나서, select문 날리는거다.

            string sql;
            sql = "select * from " + TABLE + " where parkingSpot = " + spot;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;  //select문 날리는 부분

            ds = new DataSet();
            oda.Fill(ds, TABLE);

            ParkingCar car = new ParkingCar();
            car.ParkingSpot = int.Parse(ds.Tables[0].Rows[0]["ParkingSpot"].ToString());
            car.CarNumber = ds.Tables[0].Rows[0]["CarNumber"].ToString();
            car.DriverName = ds.Tables[0].Rows[0]["DriverName"].ToString();
            car.PhoneNumber = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();
            car.ParkingTime = ds.Tables[0].Rows[0]["ParkingTime"].ToString() == "" ? new DateTime() : DateTime.Parse(ds.Tables[0].Rows[0]["ParkingTime"].ToString());


            OraConn.Close(); //db 연결 닫기
            return car;

        }

        static string generateQuery(string menu, string parkingSpot, string carNumber, string driverName, string phoneNumber)
        {
            /*
                update table1 set CarNumber = '', DriverName = '', PhoneNumber = '', ParkingTime = sysdate where parkingSpot=2;
                insert into table1 (parkingspot) values (6);
                select * from table1;
                delete from table1 where parkingspot = 6;
             */
            string query = "";

            switch (menu)
            {
                case "update":
                    // query = $"update {TABLE} set CarNumber = '{carNumber}', DriverName = '{driverName}', PhoneNumber = '{phoneNumber}', ParkingTime = TO_DATE('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}') where parkingSpot={parkingSpot}";
                    query = $"update {TABLE} set CarNumber = '{carNumber}', DriverName = '{driverName}', PhoneNumber = '{phoneNumber}', ParkingTime = sysdate where parkingSpot={parkingSpot}";
                    break;
                case "insert":
                    query = $"insert into {TABLE} (parkingspot) values({parkingSpot})";
                    break;
                case "delete":
                    query = $"delete from {TABLE} where parkingSpot={parkingSpot}";
                    break;
                default:
                    break;
            }

            
            return query;
        }

        public static void executeQuery(string menu, string parkingSpot, string carNumber=null, string driverName = null, string phoneNumber = null)
        {
            ConnectDB();

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;

                string query = "";

                query = generateQuery(menu, parkingSpot, carNumber, driverName, phoneNumber);

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                throw new Exception(ex.Message + "오류위치"+Environment.NewLine+ex.StackTrace);
            }

            OraConn.Close();

            selectQuery(); //db 연결해서 추가,수정,삭제 후 db닫고, 다시 db 연결해서
                           //조회하고, db연결 닫음
        }


        public static void PrintLog(string contents) //ParkingHistory 폴더 안의 ParkingHistory.txt파일에 로그 저장
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");
            if (!di.Exists)
            {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter("ParkingHistory" + "\\" + "ParkingHistory" + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }






    }
}
