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
                OraConn = new OracleConnection(ORADB);
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
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            ds = new DataSet(); //데이터를 저장하는 DataSet 객체 생성
            oda.Fill(ds, "myoracletest"); //DataSet에 쿼리 결과물을 저장하는 코드

            //그 결과를 List에 저장
            List<MyTest> tests = new List<MyTest>();
            //테이블에 있는 데이터만큼 foreach문을 수행함
            foreach (DataRow item in ds.Tables[0].Rows) //DataSet에 테이블이 여러개가 들어갈 수 있는 데, 현재는 하나만 들어간 거.
            {
                MyTest myTest = new MyTest();
                myTest.name = item["Name"].ToString();
                myTest.id = int.Parse(item["ID"].ToString());
                tests.Add(myTest);
            }

            //List에 있는 걸 datagridview로 옮김
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tests;
            //db연결 닫기
            OraConn.Close();
        }
    }
}
