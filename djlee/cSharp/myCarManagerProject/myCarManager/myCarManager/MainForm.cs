using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCarManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //DataManager 자체에 접근하는 순간! DataManager 안의
            //static DataManager 생성자(정적 생성자)가 호출됨
            dataGridView_parkingManager.DataSource = DataManager.Cars;
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text =
                $"현재시간 : {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}";
        }
    }
}
