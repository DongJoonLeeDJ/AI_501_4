using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCarManager
{
    public class DBHelper
    {
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        private static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                "initial Catalog={1};" +
                "integrated Security={2};" +
                "Timeout=3",
                "local", "MyCarManagerDB", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        //매개변수를 안 넣고 selectQuery()이렇게 호출하면 parkingSpot엔 -1이 들어감
        //매개변수를 넣으면 parkingSpot에 값이 들어감
        public static void selectQuery(int parkingSpot = -1)
        {
            ConnectDB(); //쿼리를 보내기 전에 DB랑 연결
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn; //연결을 해야 함...
            try
            {
                if (parkingSpot < 0) //parkingSpot이 -1인 경우
                    cmd.CommandText = "Select * from CarManager"; //CarManager= 테이블명
                else
                    cmd.CommandText = "select * from CarManager where ParkingSpot = " + parkingSpot;

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "CarManager");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message+"select쪽 오류!");
                DataManager.PrintLog(ex.StackTrace); //db연결 오류관련 내용이 로그에 저장됨
            }
            finally //try부분이 잘 되든, 잘 안 되서 catch에 걸리든 무조건 db연결을 닫아줌.
            {
                conn.Close(); //db랑 연결 끊기
            }
        }
        
        //주차 공간 추가
        public static void insertQuery(int parkingSpot)
        {
            try
            {
                ConnectDB();
                //@p1을 통해서 매개변수를 받아옴(@뒤에 아무거나 붙어도됨. @parameter1 이렇게 써도 됨)
                //이걸 쿼리문에 적용함
                
                //그냥 직접 values쪽에 parkingSpot 매개변수를 넣으면 되지, 왜 이렇게 할까?
                //Sql Injection 공격(SQL 삽입 공격) 방지
                string sqlcommand = "insert into carManager (parkingSpot) values (@p1)";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p1", parkingSpot); //@p1에 들어갈 값 삽입
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //완성된 쿼리를 db에 보냄

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "insert 오류");
                DataManager.PrintLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        //주차공간 삭제
        public static void deleteQuery(int parkingSpot)
        {
            try
            {
                ConnectDB();
                string sqlCommand = "delete from carManager where parkingSpot = @p1";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p1", parkingSpot);
                cmd.CommandText = sqlCommand;
                cmd.ExecuteNonQuery ();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);//ex.Message 예외 메시지
                DataManager.PrintLog(ex.StackTrace); //ex.StackTrace 오류위치, 어떤 오류인지 보여줌
            }
            finally
            {
                conn.Close();
            }
        }

        //주차 및 출차
        //파라메터(=매개변수, 아규먼트) 4개면 -> 주차 -> 맨끝(isRemove)에 값을 안 넣고 자동으로 false들어감
        //5개면 -> 출차
        //5개면 맨 끝에 true를 넣을 것이다.
        //맨끝에 false를 넣어준다면 출차이긴 하다.
        public static void updateQuery(int parkingSpot, string carNumber, 
                                        string driverName, string phoneNumber, 
                                        bool isRemove=false)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sqlcommand;
                if(isRemove)
                {
                    sqlcommand = "update carManager set carNumber='', driverName='', phoneNumber=''," +
                        " parkingTime=null where parkingspot=@p1";
                    cmd.Parameters.AddWithValue("@p1", parkingSpot);
                }
                else
                {
                    sqlcommand = "update carManager set carNumber=@p1, driverName=@p2, phoneNumber=@p3," +
                        "parkingtime=@p4 where parkingspot=@p5";

                    cmd.Parameters.AddWithValue("@p1", carNumber);
                    cmd.Parameters.AddWithValue("@p2", driverName);
                    cmd.Parameters.AddWithValue("@p3", phoneNumber);
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", parkingSpot);
                }
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                DataManager.PrintLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
