using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDBStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshGridView()
        {
            dataGridView1.DataSource = null;
            //이거 예외처리없으면... kBStudents가 0칸 일 때 이 코드 수행시 프로그램 튕김
            if (DataManager.kBStudents.Count > 0) 
                dataGridView1.DataSource = DataManager.kBStudents;
        }

        private void button1_Click(object sender, EventArgs e) //삽입
        {
            //DataManager.querySelect()
            //ataGridView1.DataSource = DataManager.kBStudents;
            DataManager.executeQuery("insert",int.Parse(textBox1.Text), textBox2.Text,
                int.Parse(textBox3.Text), textBox4.Text);
            refreshGridView();
        }

        private void button2_Click(object sender, EventArgs e) //조회
        {
            DataManager.selectQuery();
            refreshGridView();
        }

        private void button3_Click(object sender, EventArgs e) //수정
        {
            DataManager.executeQuery("update", int.Parse(textBox1.Text), textBox2.Text,
                int.Parse(textBox3.Text), textBox4.Text);
            refreshGridView();
        }

        private void button4_Click(object sender, EventArgs e)//삭제
        {
            DataManager.executeQuery("delete", int.Parse(textBox1.Text));
            refreshGridView();
        }
    }
}
