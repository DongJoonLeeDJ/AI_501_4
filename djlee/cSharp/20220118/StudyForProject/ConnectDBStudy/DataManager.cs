using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace = 이름공간
//똑같은 이름을 또 쓰고 싶을 때...
//다른 이름공간에서 이 이름을 쓴다.
namespace MyNamespace
{
    public class DataManager { public int age { get; set; } }
}

//namespace
//쉽게말하면
//namespace= 프로그램명 = 프로젝트명
namespace ConnectDBStudy 
{
    public class DataManager
    {
        
        //결과 데이터 저장하는 곳
        public static List<KBStudent> kBStudents = new List<KBStudent>();


        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
       "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
       "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
       "User Id=c##scott;Password=tiger;"; //오라클 연결시 필요한 기본 정보들(id,pw,port 등)
       static OracleConnection OraConn = new OracleConnection();

       public static DataSet ds;

        const string TABLE = "kb_student";

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

            string sql = "select * from "+ TABLE;
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;  //select문 날리는 부분

            ds = new DataSet();
            oda.Fill(ds, TABLE);

            //List<MyTest> tests = new List<MyTest>();
            
            kBStudents.Clear(); //기존에 있는 걸 지움

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                KBStudent kb = new KBStudent();
                kb.name = item["Name"].ToString();
                kb.hakbeon = int.Parse(item["hakbeon"].ToString());
                kb.age = int.Parse(item["age"].ToString());
                kb.gender = item["gender"].ToString();
                kBStudents.Add(kb);
            }

            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = tests;

            OraConn.Close(); //db 연결 닫기

        }

        //gender라는 매개변수는 파라메터에 값을 "여자"라고 명시하지 않는 이상
        //기본적으로 "남자"가 들어감
        //이 함수는 아래와 같이 호출됨
        //executeQuery("insert",1,"이동준",34); //남자값은 자동으로 들어감
        //executeQuery("insert",2,"이제영",35, "여자");
        //executeQuery("update",1,"DongJooneLee",34, "여자");
        //executeQuery("delete",2);

        public static void executeQuery(string menu, int hakbeon, string name=null, int age=0, string gender="남자")
        {
            ConnectDB();

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;

                string query = "";

                if(menu == "insert")
                {
                    //이렇게 어떤 건 따옴표, 어떤건 따옴표 안 주니 헷갈리므로
                    //실무에서는 그냥 varchar2로 통일하는 법도 있다.
                    query = $"insert into {TABLE} values({hakbeon},'{name}',{age},'{gender}')";
                }
                else if(menu == "update")
                {
                    query = $"update {TABLE} set name='{name}', age={age}, gender='{gender}' where hakbeon={hakbeon}";
                }
                else if(menu == "delete") //delete일 땐 name, age, gender 안 씀
                {
                    query = $"delete from {TABLE} where hakbeon={hakbeon}";
                }
                else
                {
                    throw new Exception(menu + "는 없는 쿼리문임 ㅇㅇ");
                }


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


    }
}
