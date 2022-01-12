using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp04_01_dataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //컬럼을 동적으로(=코드상에서) 추가함
            dataGridView1.Columns.Add("name", "이름");
            dataGridView1.Columns.Add("major", "전공");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
           // dataGridView1.Rows.Add(textBox1.Text+"a", textBox2.Text+"b");
           // dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
        }
    }
}
