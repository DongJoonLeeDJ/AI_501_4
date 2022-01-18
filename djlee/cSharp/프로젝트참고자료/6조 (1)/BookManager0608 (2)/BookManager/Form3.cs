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
public partial class Form3 : Form
{
        string connect_info = "DATA SOURCE = xe; User Id = BOOK; password = 1234;";
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter adt;
        DataSet Data = new DataSet();
        String temp;
        public Form3()
    {
        InitializeComponent();
        Text = "사용자 관리";

            DataSet data = new DataSet();
            string sql = "SELECT cid 고객번호,cname 고객명,cbirth 생년월일,ctel 연락처,caddress 주소,cdayover 연체여부,covercount 연체일수,ccount 대출권수,creservation 예약권수 FROM CUSTOMER";
            conn = new OracleConnection(connect_info);
            conn.Open();
            adt = new OracleDataAdapter(sql, conn);
            adt.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            // 데이터 그리드 설정
            //dataGridView1.DataSource = DataManager.Users;
            label6.Text = Convert.ToString(data.Tables[0].Rows.Count);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cid = string.Format(textBox1.Text); // 아이디
            string cname = string.Format(textBox2.Text); // 이름
            string cbirth = string.Format(textBox3.Text); // 생년월일
            string ctel = string.Format(textBox4.Text); // 전화번호
            string caddress = string.Format(textBox5.Text); // 주소
            DataSet Data = new DataSet();
            string sql = "INSERT INTO CUSTOMER (CID,CNAME,CBIRTH,CTEL,CADDRESS) VALUES ('" + cid + "','" + cname + "','" + cbirth + "','" + ctel + "','" + caddress + "')";
            string sql2 = "SELECT * FROM CUSTOMER";

            conn = new OracleConnection(connect_info);
            conn.Open();
            comm = new OracleCommand(sql, conn);
            comm.ExecuteNonQuery();
            adt = new OracleDataAdapter(sql2, conn);
            adt.Fill(Data);
            dataGridView1.DataSource = Data.Tables[0];
            label6.Text = Convert.ToString(Data.Tables[0].Rows.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cid = string.Format(textBox1.Text); // 아이디
            string cname = string.Format(textBox2.Text); // 이름
            string cbirth = string.Format(textBox3.Text); // 생년월일
            string ctel = string.Format(textBox4.Text); // 전화번호
            string caddress = string.Format(textBox5.Text); // 주소
            DataSet Data = new DataSet();

            string sql = "UPDATE CUSTOMER SET CID='" + cid + "', CNAME='" + cname + "', CBIRTH ='" + cbirth + "', CTEL='" + ctel + "', CADDRESS='" + caddress + "' WHERE CID='" + temp + "'";
            string sql2 = "SELECT * FROM CUSTOMER";
            conn = new OracleConnection(connect_info);
            conn.Open();
            comm = new OracleCommand(sql, conn);
            comm.ExecuteNonQuery();
            adt = new OracleDataAdapter(sql2, conn);
            adt.Fill(Data);
            dataGridView1.DataSource = Data.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cid = string.Format(textBox1.Text);
            string sql = "DELETE FROM CUSTOMER WHERE CID='" + cid + "'";
            string sql2 = "SELECT * FROM CUSTOMER";
            DataSet Data = new DataSet();

            conn = new OracleConnection(connect_info);
            conn.Open();
            comm = new OracleCommand(sql, conn);
            comm.ExecuteNonQuery();
            adt = new OracleDataAdapter(sql2, conn);
            adt.Fill(Data);
            dataGridView1.DataSource = Data.Tables[0];
            label6.Text = Convert.ToString(Data.Tables[0].Rows.Count);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            temp = textBox1.Text;
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
