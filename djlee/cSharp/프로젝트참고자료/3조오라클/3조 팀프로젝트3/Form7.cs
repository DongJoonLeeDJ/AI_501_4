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
    public partial class Form7 : Form
    {
        OracleConnection oracleConnection;
        public Form7()
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

            query = "Select * from 총사업장정보";
            da = new OracleDataAdapter(query, oracleConnection);
            da.Fill(ds, "총사업장정보");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "총사업장정보";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            grid();
        }

        private void Form7_Load_1(object sender, EventArgs e)
        {
            grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd;
            string de = "select 사업장이름, 사업장주소, 방타입, 방개수, 요금 from 총사업장정보 where 사업장주소 like '%" + textBox1.Text + "%'";
            if (textBox1.Text == "") MessageBox.Show("delete!");
            if (MessageBox.Show("검색하겠습니까? ", "검색", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                open_conn();
                cmd = new OracleCommand();
                try
                {
                    OracleDataAdapter da;
                    DataSet ds;
                    ds = new DataSet();
                    string query;

                    query = "Select * from 총사업장정보";
                    da = new OracleDataAdapter(de, oracleConnection);
                    da.Fill(ds, "총사업장정보");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "총사업장정보";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox1.Focus();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
