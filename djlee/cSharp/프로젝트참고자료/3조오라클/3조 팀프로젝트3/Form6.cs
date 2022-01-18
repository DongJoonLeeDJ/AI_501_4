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

namespace _3조_팀프로젝트3
{
    public partial class Form6 : Form
    {
        OracleConnection oracleConnection;
        public Form6()
        {
            InitializeComponent();
#pragma warning disable CS0618 // Type or member is obsolete
            oracleConnection = new OracleConnection("Data Source=192.168.0.31;User ID=team3;Password=1234;Unicode=True");
#pragma warning restore CS0618 // Type or member is obsolete
        }

        private void open_conn()
        {
            if (oracleConnection.State == ConnectionState.Closed) oracleConnection.Open();
        }

        private void grid()
        {
            OracleDataAdapter da;
            DataSet ds;
            ds = new DataSet();
            string query;

            query = "Select * from 예약내역";
            da = new OracleDataAdapter(query, oracleConnection);
            da.Fill(ds, "예약내역");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "예약내역";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            grid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["예약번호"].Value.ToString() == "")
            {
                MessageBox.Show("first", "second", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["예약번호"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["일련번호"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["고객번호"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["예약시작일"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["예약종료일"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["인원수"].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["결제방식"].Value.ToString();
            }
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd;
            string query = "";
            int row;

            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter("select * from 예약내역 where 예약번호 = '" + textBox1.Text + "'", oracleConnection);
            row = da.Fill(ds, "예약내역");

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("빈칸이 있습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else
            {
                if (row == 0)
                {
                    if (MessageBox.Show("입력하겠습니까? ", "입력", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        query = "insert into 예약내역(예약번호, 일련번호, 고객번호, 예약시작일, 예약종료일, 인원수, 결제방식) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "',TO_DATE('" + textBox4.Text + "','YYYY-MM-DD'),TO_DATE('" + textBox5.Text + "','YYYY-MM-DD'),'" + textBox6.Text + "','" + textBox7.Text + "')";
                        MessageBox.Show("입력되었습니다");
                    }

                }
                else
                {
                    query = "update 예약내역 set 일련번호 = '" + textBox2.Text + "',고객번호 = '" + textBox3.Text + "',예약시작일 = TO_DATE('" + textBox4.Text + "','YYYY-MM-DD'),예약종료일 = TO_DATE('" + textBox5.Text + "','YYYY-MM-DD'),인원수 = '" + textBox6.Text + "',결제방식 = '" + textBox7.Text + "' where 예약번호 = '" + textBox1.Text + "'";
                    MessageBox.Show("갱신되었습니다");
                }
                cmd = new OracleCommand();
                open_conn();
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = oracleConnection;
                    row = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox1.Focus();
                }
                grid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd;
            string de = "delete from 예약내역 where 예약번호 = '" + textBox1.Text + "'";
            if (textBox1.Text == "") MessageBox.Show("delete!");
            if (MessageBox.Show("삭제하겠습니까? ", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                open_conn();
                cmd = new OracleCommand();
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = de;
                    cmd.Connection = oracleConnection;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox1.Focus();
                }
            }
            grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
