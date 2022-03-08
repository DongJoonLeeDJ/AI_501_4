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
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();

            if (DataManager.Users.Count > 0)
                dataGridView_Users.DataSource = DataManager.Users;

            dataGridView_Users.CellClick += dataGridView_Users_cellClick;
        }

        private void dataGridView_Users_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = dataGridView_Users.CurrentRow.DataBoundItem as User;
            textBox_ID.Text = user.Id.ToString();
            textBox_Name.Text = user.Name;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //Exists
            //괄호 안에 있는 조건이 해당되면 true를 반환
            if(DataManager.Users.Exists(x=>x.Id == int.Parse(textBox_ID.Text)))
                MessageBox.Show("해당 ID의 유저 이미 존재");
            else
            {
                //생성자 자체에는 아무것도 없음.
                //선언과 동시에 멤버변수에 값을 부여하는 방식(중괄호 안에 속성이 자동완성으로 나타남)
                User user = new User() { Id = int.Parse(textBox_ID.Text), Name = textBox_Name.Text };
                DataManager.Users.Add(user);

                dataGridView_Users.DataSource = null;
                dataGridView_Users.DataSource = DataManager.Users; 
                DataManager.Save(); //바뀐 Users를 xml에 새로 반영시킴
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                User user = DataManager.Users.Single(x => x.Id == int.Parse(textBox_ID.Text));
                user.Name = textBox_Name.Text;
                try
                {
                    //만약 유저의 이름을 바꿨는 데, 그 유저가 책을 빌린 유저라면
                    //Books의 UserName도 같이 바꿔야 한다.
                    Book book = DataManager.Books.Single((x) => x.UserId == int.Parse(textBox_ID.Text));
                    book.UserName = textBox_Name.Text;
                }
                catch (Exception)
                {
                    //해당 유저ID가 책 빌린 거 없으면 아무 것도 안 한다.
                }
            }
            catch (Exception)
            {
                //해당 아이디가 없으면 아무것도 안 함
                MessageBox.Show("이 아이디는 없습니다.");
            }

            dataGridView_Users.DataSource = null;
            dataGridView_Users.DataSource = DataManager.Users;
            DataManager.Save();


        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox_ID.Text));
                DataManager.Users.Remove(user); //user는 Users안에서 textBox_ID와 일치한 ID를 가진 객체의 위치
                //따라서 Remove(user)하면 Users에서 해당 객체가 정확하게 지워진다.
                //ref

                dataGridView_Users.DataSource = null;
                if (DataManager.Users.Count > 0)
                    dataGridView_Users.DataSource = DataManager.Users;

                DataManager.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("해당 사용자 없습니다.");
            }
        }
    }
}
