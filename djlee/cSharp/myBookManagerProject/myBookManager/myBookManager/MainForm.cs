using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBookManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_now.Text
                = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show :모달리스 -> 창 띄우고 그 밑에 코드들도 수행. 뒤에 화면 조작 O
            //ShowDialog : 모달 -> 창을 띄우면 코드가 여기서 멈춤. 뒤에 화면 조작X
            new BookManager().ShowDialog();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserManager().ShowDialog();
        }
    }
}
