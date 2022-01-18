using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace StudyForProject
{
    public partial class Form1 : Form
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
               "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
               "User Id=c##scott;Password=tiger;"; //오라클 연결시 필요한 기본 정보들(id,pw,port 등)
        OracleConnection OraConn = new OracleConnection();

        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_select_Click(object sender, System.EventArgs e)
        {
            //오라클 연결하는 부분
            try
            {
                OraConn = new OracleConnection(ORADB); //오라클 접속
                OraConn.Open(); //oracle db를 열었다.
            }
            catch (System.Exception ex)
            {
                throw;
            }
            //쿼리문 날리기
            string sql = "select * from myoracletest"; //문자열 안에 세미콜론 넣지 말기
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand(); //커멘드라인 저장할 객체 생성
            oda.SelectCommand.Connection = OraConn; //어디에 접속할지 정함
            oda.SelectCommand.CommandText = sql; //쿼리문 날림

            ds = new DataSet(); //데이터를 저장하는 DataSet 객체 생성
            oda.Fill(ds, "myoracletest"); //DataSet에 쿼리 결과물을 저장하는 코드

            //그 결과를 List에 저장
            List<MyTest> tests = new List<MyTest>();
            //테이블에 있는 데이터만큼 foreach문을 수행함
            foreach (DataRow item in ds.Tables[0].Rows) //DataSet에 테이블이 여러개가 들어갈 수 있는 데, 현재는 하나만 들어간 거.
            {
                MyTest myTest = new MyTest(); //인스턴스 생성
                myTest.name = item["Name"].ToString(); //각 속성들 값을 ds에서 읽어옴
                myTest.id = int.Parse(item["ID"].ToString());
                tests.Add(myTest);
            }

            //List에 있는 걸 datagridview로 옮김
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tests;
            //db연결 닫기
            OraConn.Close();
        }

        private void btn_insert_Click(object sender, System.EventArgs e)
        {



            //db랑 연결 -> 똑같은 코드가 계속 반복 됨...
            //오라클 연결하는 부분
            try
            {
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
            }
            catch (System.Exception)
            {
                throw;
            }
            try
            {
                //db에 insert문 전송
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                cmd.CommandText = $"insert into myoracletest values ({textBox_ID.Text},'{textBox_Name.Text}')";
                //$"insert into teacher values ('{textBox_Name.Text}', {textBox_ID.Text}, '{textBox_Name.Text}')";
                cmd.ExecuteNonQuery();
                //db 연결 닫기
                OraConn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message); // 에러 메시지 출력
                MessageBox.Show(ex.StackTrace); //어디서 에러났는지 출력
                throw; //에러메시지 던지고 프로그램 꺼짐(계속하기 누르면 계속 되긴 함)
            }



        }

        private void btn_update_Click(object sender, System.EventArgs e)

        {

            //Name이 label3인 것을 form주에서 찾아내서 그 것의 text 변경
            //foreach (var item in Controls)
            //for(int i = 0; i<Controls.Count; i++)
            //{
            //    if(Controls[i] is Label)
            //    {
            //        if((Controls[i] as Label).Name == "label3")
            //        {
            //            Controls[i].Text = "zzzz";
            //        }
            //    }
            //}
            
            //db랑 연결 -> 똑같은 코드가 계속 반복 됨...
            //오라클 연결하는 부분
            try
            {
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
            }
            catch (System.Exception)
            {
                throw;
            }
            try
            {
                //db에 update문 전송
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                cmd.CommandText = $"update myoracletest set name='{textBox_Name.Text}' where id={textBox_ID.Text}";
                //$"insert into teacher values ('{textBox_Name.Text}', {textBox_ID.Text}, '{textBox_Name.Text}')";
                cmd.ExecuteNonQuery();
                //db 연결 닫기
                OraConn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message); // 에러 메시지 출력
                MessageBox.Show(ex.StackTrace); //어디서 에러났는지 출력
                throw; //에러메시지 던지고 프로그램 꺼짐(계속하기 누르면 계속 되긴 함)
            }



        }

        private void btn_delete_Click(object sender, System.EventArgs e)
        {

            //db랑 연결 -> 똑같은 코드가 계속 반복 됨...
            //오라클 연결하는 부분
            try
            {
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
            }
            catch (System.Exception)
            {
                throw;
            }
            try
            {
                //db에 update문 전송
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                cmd.CommandText = $"delete from myoracletest where id={textBox_ID.Text}";
                //$"insert into teacher values ('{textBox_Name.Text}', {textBox_ID.Text}, '{textBox_Name.Text}')";
                cmd.ExecuteNonQuery();
                //db 연결 닫기
                OraConn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message); // 에러 메시지 출력
                MessageBox.Show(ex.StackTrace); //어디서 에러났는지 출력
                throw; //에러메시지 던지고 프로그램 꺼짐(계속하기 누르면 계속 되긴 함)
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            new Form2().Show();
        }
    }
}
