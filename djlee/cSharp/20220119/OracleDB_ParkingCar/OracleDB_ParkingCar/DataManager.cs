using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleDB_ParkingCar
{
    public class DataManager
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
                  "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                  "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
                  "User Id=c##scott;Password=tiger;";
        public static OracleConnection OraConn = new OracleConnection(ORADB); //오라클 연결 정보 생성

        public static List<ParkingCar> cars = new List<ParkingCar>();

        const string TABLE = "parkingcar";

        static void ConnectDB()  //참고로 앞에 아무것도 안 붙이면 private이 붙은 거랑 똑같다.
        {
            try
            {
                OraConn.Open();
            }
            catch (Exception ex)
            {
                //throw;
                //에러 메시지 띄워주고
                //어디에 있는지도 띄워줌
                //그냥 throw만 날려도 에러를 보여주긴 하는 데
                //아래처럼 에러관련된 것도 커스터마이징 가능

                //Environment.NewLine = "\n"; //개행문자
                //리눅스, 맥, 윈도우 등 환경에 따라서 개행문자가 다르므로 Environment.NewLine 하면
                //환경에 따라 해당되는 개행문자 넣어줌
                throw new Exception("DB 연결 에러 " + ex.Message + "에러 위치 " + Environment.NewLine+ ex.StackTrace);
            }
        }

        //select문으로 테이블 조회하기
        public static void selectQuery()
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE + " order by to_number(parkingspot)"; //테이블을 조회하되, 주차공간번호를 기준으로 조회

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql; //select문을 날린 거

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            cars.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ParkingCar car = new ParkingCar();
                car.ParkingSpot = int.Parse(item["parkingSpot"].ToString());
                car.CarNumber = item["CarNumber"].ToString();
                car.DriverName = item["DriverName"].ToString();
                car.PhoneNumber = item["PhoneNumber"].ToString();
                //ParkingTime 컬럼에 아무것도 없다면 ParkingTime 속성에 new DateTime()//(현재시간) 삽입
                //아니면 테이블에서 읽어온 값 그대로 삽입
                car.ParkingTime = item["ParkingTime"].ToString() 
                    == "" ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());

                cars.Add(car);
            }

            OraConn.Close();
        }

        //특정한 공간에 이미 주차되어 있거나 출차되어 있는 걸
        //체크 하기 위해서 한 군데의 상태를 조회하는 함수
        //위의 selectQuery랑 이름은 똑같으나 매개변수가 다르므로 다른 함수로 취급(=오버로딩)
        public static ParkingCar selectQuery(int spot)
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE + " where parkingSpot="+ spot +" order by to_number(parkingspot)"; //테이블을 조회하되, 주차공간번호를 기준으로 조회

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql; //select문을 날린 거

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

                DataRow item = ds.Tables[0].Rows[0];
                ParkingCar car = new ParkingCar();
                car.ParkingSpot = int.Parse(item["parkingSpot"].ToString());
                car.CarNumber = item["CarNumber"].ToString();
                car.DriverName = item["DriverName"].ToString();
                car.PhoneNumber = item["PhoneNumber"].ToString();
                //ParkingTime 컬럼에 아무것도 없다면 ParkingTime 속성에 new DateTime()//(현재시간) 삽입
                //아니면 테이블에서 읽어온 값 그대로 삽입
                car.ParkingTime = item["ParkingTime"].ToString()
                    == "" ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());

            OraConn.Close();
            return car;
        }

        static string Query(string menu, string parkingSpot, string carNumber, string driverName, string phoneNumber)
        {
            string query = "";
            switch (menu)
            {
                case "update":
                    query = $"update {TABLE} set CarNumber='{carNumber}', DriverName='{driverName}', " +
                        $"phoneNumber='{phoneNumber}', parkingTime=sysdate where parkingspot={parkingSpot}";
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

        //executeQuery("delete",1)
        //executeQuery("update",1,"30규1234","이동준","010-2940-1613")
        //삽입, 삭제, 수정 역할 함
        //삽입 : 주차공간 추가, 삭제 : 주차공간 삭제, 수정 : 주차 및 출차처리
        public static void executeQuery(string menu, string parkingSpot, string carNumber=null, string driverName=null, string phoneNumber=null)
        {
            ConnectDB();
            string query = "";
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                query = Query(menu, parkingSpot, carNumber, driverName, phoneNumber);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) //쿼리문에 문제 생길 시 오류 발생
            {
                //쿼리문과 함께 오류 메시지들 출력
                OraConn.Close(); //쿼리 날렸을 때 실패하면 db접속을 닫아준다.
                throw new Exception(query+ "_" +ex.Message+"오류위치"+Environment.NewLine+ex.StackTrace);
            }

            OraConn.Close();

            selectQuery(); //수정 삭제 삽입 후 테이블 조회해서 cars List 업데이트 시킴
        }

    }
}
