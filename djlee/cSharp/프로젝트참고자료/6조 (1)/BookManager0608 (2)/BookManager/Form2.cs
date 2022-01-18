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
public partial class Form2 : Form
{
        string connect_info = "DATA SOURCE = xe; User Id = BOOK; password = 1234;";
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter adt;
        String temp;
        DataSet Data = new DataSet();
        public Form2()
    {
        InitializeComponent();
        Text = "도서 관리";
            
            DataSet data = new DataSet();
            string sql = "SELECT bid 도서번호,bname 도서명,bauthor 저자,bcompany 출판사,byear 발행년도,bstate 대출현황,bday 대출일자, breturn 반납일자,bbook 예약현황,bcount 대출횟수,bnew 신간도서,bold 폐도서  FROM BOOK";
            conn = new OracleConnection(connect_info);
            conn.Open();
            adt = new OracleDataAdapter(sql, conn);
            adt.Fill(data);
            dataGridView1.DataSource = data.Tables[0];

            // 데이터 그리드 설정
            //dataGridView1.DataSource = DataManager.Books;
            //dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;

        // 버튼 설정
       /* button1.Click += (sender, e) =>
        {
            // 추가 버튼
            try
            {
                if (DataManager.Books.Exists((x) => x.Isbn == textBox1.Text))
                {
                    MessageBox.Show("이미 존재하는 도서입니다");
                }
                else
                {
                    Book book = new Book()
                    {
                        Isbn = textBox1.Text,
                        Name = textBox2.Text,
                        Publisher = textBox3.Text,
                        Page = int.Parse(textBox4.Text)
                    };
                    DataManager.Books.Add(book);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Books;
                    DataManager.Save();
                }
            }
            catch (Exception exception)
            {

            }
        };*/

        /*button2.Click += (sender, e) =>
        {
            // 수정 버튼
            try
            {
                Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                book.Name = textBox2.Text;
                book.Publisher = textBox3.Text;
                book.Page = int.Parse(textBox4.Text);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Books;
                DataManager.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 도서입니다");
            }
        };*/

        /*button3.Click += (sender, e) =>
        {
            // 수정 버튼
            try
            {
                Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                DataManager.Books.Remove(book);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Books;
                DataManager.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 도서입니다");
            }
        };*/
    }

    private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
    {
        try
        {
            // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
            Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
            textBox1.Text = book.Isbn;
            textBox2.Text = book.Name;
            textBox3.Text = book.Publisher;
            textBox4.Text = book.Page.ToString();
        }
        catch (Exception exception)
        {

        }
    }

        private void button1_Click(object sender, EventArgs e) //입력
        {
            string bid = string.Format(textBox1.Text); // 아이디
            string bname = string.Format(textBox2.Text); // 이름
            string bauthor = string.Format(textBox3.Text); // 저자
            string bcompany = string.Format(textBox4.Text); // 출판사
            string byear = string.Format(textBox5.Text); // 발행년도
            DataSet Data = new DataSet();
            string sql = "INSERT INTO BOOK (BID,BNAME,BAUTHOR,BCOMPANY,BYEAR) VALUES ('" + bid + "','" + bname + "','" + bauthor + "','" + bcompany + "','" + byear + "')";
            string sql2 = "SELECT * FROM BOOK";

            conn = new OracleConnection(connect_info);
            conn.Open();
            comm = new OracleCommand(sql, conn);
            comm.ExecuteNonQuery();
            adt = new OracleDataAdapter(sql2, conn);
            adt.Fill(Data);
            dataGridView1.DataSource = Data.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e) //삭제
        {
            string bid = string.Format(textBox1.Text);
            string sql = "DELETE FROM BOOK WHERE BID='"+bid+"'";
            string sql2 = "SELECT * FROM BOOK";
            DataSet Data = new DataSet();

            conn = new OracleConnection(connect_info);
            conn.Open();
            comm = new OracleCommand(sql, conn);
            comm.ExecuteNonQuery();
            adt = new OracleDataAdapter(sql2, conn);
            adt.Fill(Data);
            dataGridView1.DataSource = Data.Tables[0];
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

        private void button2_Click(object sender, EventArgs e) //수정
        {
            string bid = string.Format(textBox1.Text); // 아이디
            string bname = string.Format(textBox2.Text); // 이름
            string bauthor = string.Format(textBox3.Text); // 저자
            string bcompany = string.Format(textBox4.Text); // 출판사
            string byear = string.Format(textBox5.Text); // 발행년도
            DataSet Data = new DataSet();

            string sql = "UPDATE BOOK SET BID='" + bid + "', BNAME='" + bname + "', BAUTHOR ='" + bauthor + "', BCOMPANY='" + bcompany + "', BYEAR='" + byear + "' WHERE BID='" + temp + "'";
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