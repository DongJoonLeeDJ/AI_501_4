using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyForProject
{
    public partial class Form2 : Form
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
       "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
       "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
       "User Id=c##scott;Password=tiger;"; //오라클 연결시 필요한 기본 정보들(id,pw,port 등)
        OracleConnection OraConn = new OracleConnection();

        DataSet ds;

        public Form2()
        {
            InitializeComponent();
        }

        //DB 연결해주는 함수
        public void ConnectDB()
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

        public void selectQuery()
        {
            ConnectDB(); //db연결 해주고 나서, select문 날리는거다.

            string sql = "select * from myoracletest";
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;  //select문 날리는 부분

            ds = new DataSet();
            oda.Fill(ds, "myoracletest");

            List<MyTest> tests = new List<MyTest>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                MyTest mytest = new MyTest();
                mytest.id = int.Parse(item["id"].ToString());
                mytest.name = item["name"].ToString();
                tests.Add(mytest);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tests;

            OraConn.Close(); //db 연결 닫기

        }

        public void executeQuery(string query)
        {
            ConnectDB();

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            OraConn.Close();

            selectQuery(); //db 연결해서 추가,수정,삭제 후 db닫고, 다시 db 연결해서
                            //조회하고, db연결 닫음
        }



        private void button_select_Click(object sender, EventArgs e)
        {
            selectQuery();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            executeQuery($"insert into myoracletest values ({textBox1.Text}, '{textBox2.Text}')");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            executeQuery($"update myoracletest set name='{textBox2.Text}' where id={textBox1.Text}");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            executeQuery($"delete from myoracletest where id={textBox1.Text}");
        }
    }
}
