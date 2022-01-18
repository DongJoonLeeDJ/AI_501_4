using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
public partial class Form1 : Form
{
        string connect_info = "DATA SOURCE = xe; User Id = BOOK; password = 1234;";
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter adt;
        OracleDataAdapter adt2;
        String search_name;
        string tempForReturn;
        string tempID;
        int count;
        public Form1()
    {
        InitializeComponent();
        Text = "도서관 관리";

        DataSet data = new DataSet();
        DataSet data2 = new DataSet();
        string sql = "SELECT bid 도서번호,bname 도서명,bauthor 저자,bcompany 출판사,byear 발행년도,bstate 대출현황,bday 대출일자, breturn 반납일자,bbook 예약현황,bcount 대출횟수,bnew 신간도서,bold 폐도서  FROM BOOK";
        string sql2 = "SELECT * FROM V_RESERVE";
        conn = new OracleConnection(connect_info);
        conn.Open();
        adt = new OracleDataAdapter(sql, conn);
        adt2 = new OracleDataAdapter(sql2, conn);
        adt.Fill(data);
        adt2.Fill(data2);
        dataGridView1.DataSource = data.Tables[0];
        dataGridView2.DataSource = data2.Tables[0];
        label5.Text = Convert.ToString(data.Tables[0].Rows.Count);
        label4.Text = Convert.ToString(data2.Tables[0].Rows.Count);
        count = Convert.ToInt32(data.Tables[0].Rows.Count);
        
            // 라벨 설정
            /*   label5.Text = DataManager.Books.Count.ToString();
           label6.Text = DataManager.Users.Count.ToString();
           label7.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
           label8.Text = DataManager.Books.Where((x) => {
               return x.isBorrowed && x.BorrowedAt.AddDays(7) > DateTime.Now;
           }).Count().ToString();*/

            // 데이터 그리드 설정
            /*dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;*/
            /*dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
            dataGridView2.CurrentCellChanged += DataGridView2_CurrentCellChanged;*/

            // 버튼 이벤트 설정
    }

        

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new Form2().ShowDialog();
    }

    private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new Form3().ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DataSet data = new DataSet();
        search_name = textBox1.Text;
        string sql = "SELECT * FROM BOOK WHERE BNAME like '%" + search_name + "%'";
        conn = new OracleConnection(connect_info);
        conn.Open();
        adt = new OracleDataAdapter(sql, conn);
        adt.Fill(data);
        dataGridView1.DataSource = data.Tables[0];
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        tempForReturn = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        tempID = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            string sql = "SELECT * FROM BOOK";
            conn = new OracleConnection(connect_info);
            conn.Open();
            adt = new OracleDataAdapter(sql, conn);
            adt.Fill(data);
            label5.Text = Convert.ToString(data.Tables[0].Rows.Count);
        }

        private void button2_Click(object sender, EventArgs e) //대출
        {
            string cid = string.Format(textBox2.Text); // 아이디
            DataSet Data = new DataSet();
            string sql = "UPDATE BOOK SET bstate = '" + cid + "' where bid='" + tempForReturn + "'";
            string sql2 = "SELECT * FROM BOOK";

            if (tempID != "")
            {
                MessageBox.Show("이미 대출중인 도서입니다.");
            }
            else {
                conn = new OracleConnection(connect_info);
                conn.Open();
                comm = new OracleCommand(sql, conn);
                comm.ExecuteNonQuery();
                adt = new OracleDataAdapter(sql2, conn);
                adt.Fill(Data);
                dataGridView1.DataSource = Data.Tables[0];
            }
        }

        private void button3_Click(object sender, EventArgs e) //반납
        {
            string cid = string.Format(textBox2.Text); // 아이디
            DataSet Data = new DataSet();
            string sql = "UPDATE BOOK SET BSTATE = null where bid='" + tempForReturn + "'";
            string sql2 = "SELECT * FROM BOOK";

            conn = new OracleConnection(connect_info);
            conn.Open();
            comm = new OracleCommand(sql, conn);
            comm.ExecuteNonQuery();
            adt = new OracleDataAdapter(sql2, conn);
            adt.Fill(Data);
            dataGridView1.DataSource = Data.Tables[0];
        }
    }
}
