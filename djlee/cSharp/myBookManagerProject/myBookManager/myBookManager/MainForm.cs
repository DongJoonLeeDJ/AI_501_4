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

            label_allBookCount.Text = DataManager.Books.Count.ToString();
            label_allUserCount.Text = DataManager.Users.Count.ToString();

            //Console.WriteLine("\t안녕\t하세요");

            //대출중인 도서의 수 세기
            //1. foreach문 돌리면서 if문을 써서, isBorrowed가 true인 것의 개수를 세는 방법
            //2. where 이라는 이름의 메소드. 매개변수는 람다식.

            //Where 괄호 안에 있는 식 해석
            //x : Books 안에 들어가 있는 Book 객체들 하나하나이다.
            //=>x.isBorrowed : true값인 것만 추출해는 것
            
            //위 아래 코드는 똑같은 거
            label_allBorrowedBook.Text = DataManager.Books.Where(x=>x.isBorrowed).Count().ToString();
            //label_allBorrowedBook.Text = DataManager.Books.Where(delegate (Book x) 
            //{ return x.isBorrowed; }).Count().ToString();

            label_allDelayedBook.Text = DataManager.Books.Where
                (x=> x.isBorrowed&&x.BorrowedAt.AddDays(7)<DateTime.Now).Count().ToString();

            //label_allDelayedBook.Text = DataManager.Books.Where(
            //    delegate (Book x) { return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;  } ).
            //    Count().ToString();

            //Users, Books가 길이가 0인데, 길이가 0인걸 DataGridview의 데이터소스로 지정시
            //문제가 생길 수 있다.
            //셀 클릭시 범위를 벗어나서 접근했다 등의 메시지를 띄우며 튕김.
            if (DataManager.Users.Count > 0)
                dataGridView_userManager.DataSource = DataManager.Users;
            if (DataManager.Books.Count > 0)
                dataGridView_bookManager.DataSource = DataManager.Books;


            //데이터 그리드뷰의 셀을 눌러서 대여/반납 안에 있는 텍스트박스들에 값을 채워넣는 것
            //이벤트 추가는 하는 데, 델리게이터, 람다 이용해보기.
            dataGridView_bookManager.CellClick += (sender, e) =>
            {
                Book book = dataGridView_bookManager.CurrentRow.DataBoundItem as Book;
                textBox_isbn.Text = book.Isbn;
                textBox_bookName.Text = book.Name;
            };

            dataGridView_userManager.CellClick += delegate (object sender, DataGridViewCellEventArgs e)
            {
                User user = dataGridView_userManager.CurrentRow.DataBoundItem as User;
                textBox_id.Text = user.Id.ToString();
            };

            button_borrow.Click += Button_Borrow_Click;


        }

        private void Button_Borrow_Click(object sender, EventArgs e)
        {
            if(textBox_isbn.Text.Trim() == "") //Trim() : 양옆 공백 제거
                MessageBox.Show("isbn 값이 없습니다.");
            else if(textBox_id.Text.Trim() == "")
                MessageBox.Show("사용자 id 입력하세요.");
            else
            {
                try
                {
                    //Single
                    //괄호 안에 조건을 만족하는 객체 1개의 주소(엄밀히 따지면 참조변수)를 반환함
                    //여기서 x는 Books 안에 들어가 있는 Book 객체들.
                    //해당 isbn의 책이 없으면 catch로 빠짐
                    //책이 이미 빌린건지 체크
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                    if(book.isBorrowed)
                    {
                        MessageBox.Show("이미 빌렸습니다.");
                    } 
                    else
                    {
                        //여기서 x는 Users 리스트의 값들
                        //만약 해당하는 user가 없으면 catch부분으로 빠짐(Exception 발생)
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox_id.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView_bookManager.DataSource = null;
                        dataGridView_bookManager.DataSource = DataManager.Books;
                        DataManager.Save(); //Books.xml, Users.xml에 내용 덮어쓰기
                        MessageBox.Show($"{book.Name}이/가 {user.Name}님께 대여되었습니다.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 혹은 사용자입니다.");
                }
            } 

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
