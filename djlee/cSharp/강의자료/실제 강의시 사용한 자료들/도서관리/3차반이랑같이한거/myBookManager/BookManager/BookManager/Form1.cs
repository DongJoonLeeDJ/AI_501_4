using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //데이터가 아무것도 없더라도 이상한 글자는 안 나오게 하기 위함
            label_allBookCount.Text = "";
            label_allUserCount.Text = "";
            label_allBorrowedBook.Text = "";
            label_allDelayedBook.Text = "";

            //현재로선 껐다켜면 이 부분이 잘 나옴.

            //만약 실시간으로 바꾸고 싶다면 아래와 같이 하면 된다.
            //도서관 현황 부분 수정
            //1. 책 추가할 때
            //2. 책 빌릴 때
            //3. 책 반납할 때 
            //+4) 프로그램 켤 때 날짜 점검해서 반납일이 지난 게 있으면 연체중인거 하나 올리고 대출중인 거 하나 깎는다.


            label_allBookCount.Text = DataManager.Books.Count.ToString();
            label_allUserCount.Text = DataManager.Users.Count.ToString();

            //대출중인 도서의 수
            //where이라는 메소드(List에서 쓰임)
            //Where 안에 메소드가 매개변수로 들어감(람다)
            //x : Books에 있는 값들. 만약 책이 3권 들어가면 x는 3개.

            //Books에 있는 값들을 하나 하나 읽어가면서, isBorrowed값이 true인 것의 개수(=Count())를 세서 String으로 변환(ToString())
            label_allBorrowedBook.Text = DataManager.Books.Where(x => x.isBorrowed).Count().ToString();

            //연체중인 도서의 수
            //빌린 상태 + 빌리고나서 7일이 지난 것
            //Where안에 들어가는 메소드. 매개변수는 Book 타입 변수 1개, 반환값은 bool
            label_allDelayedBook.Text = DataManager.Books.Where(
                delegate (Book x) { return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now; } ).Count().ToString();

            //데이터 그리드 뷰 설정
            //길이가 0인 List를 DataGridView에 집어넣고, Cell을 클릭하면 프로그램이 튕기는 오류있음
            if(DataManager.Users.Count > 0)
                dataGridView_UserManager.DataSource = DataManager.Users;

            if(DataManager.Books.Count > 0)
                dataGridView_BookManager.DataSource = DataManager.Books;

            dataGridView_BookManager.CellClick += Book_GridView_CellClick; //cell을 눌렀을 때 이벤트를 코드상으로 추가함

        }

        private void Book_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // throw new NotImplementedException();
           Book book = dataGridView_BookManager.CurrentRow.DataBoundItem as Book; //내가 클릭한 걸 Book으로 형변환
           textBox_isbn.Text = book.Isbn;
           textBox_bookName.Text = book.Name;
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog(); //모달. //이 창을 꺼야지 그 밑에 코드들도 수행됨

            //도서관리 창에서 책을 수정하든 지우든 추가하든 했을 것이다.
            DataManager.Load(); //Save한 값을 다시 호출해서 DataManager에 있는 List를 리셋함
            dataGridView_BookManager.DataSource = null;
            if (DataManager.Books.Count > 0)
                dataGridView_BookManager.DataSource = DataManager.Books;
        }

        private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            DataManager.Load();
            dataGridView_UserManager.DataSource= null;
            if(DataManager.Users.Count>0)
            dataGridView_UserManager.DataSource = DataManager.Users;
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH:mm:ss");
        }

        private void dataGridView_UserManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = dataGridView_UserManager.CurrentRow.DataBoundItem as User;
            textBox_id.Text = user.Id.ToString();
        }

        private void button_Borrow_Click(object sender, EventArgs e)
        {
            if(textBox_isbn.Text.Trim() == "") //양옆공백제거시에도 아무것도 없을 때
                MessageBox.Show("isbn입력하세요.");
            else if(textBox_id.Text.Trim() =="")
                MessageBox.Show("사용자 id 입력하세요.");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_isbn.Text); //내가 빌릴 책
                    if(book.isBorrowed)
                        MessageBox.Show("이미 빌렸다.");
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox_id.Text); //책을 빌릴 사람
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView_BookManager.DataSource = null;
                        dataGridView_BookManager.DataSource = DataManager.Books;
                        DataManager.Save();
                        MessageBox.Show($"{book.Name}이/가 {user.Name}님께 대여되었습니다.");

                    }
                }
                catch (Exception)
                {
                    //Single에서 해당 값을 못 찾을 경우 이리로 이동함.
                    MessageBox.Show("존재하지 않는 도서 혹은 사용자입니다.");
                }
            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            if(textBox_isbn.Text.Trim()=="")
                MessageBox.Show("isbn입력하세요");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                    if(book.isBorrowed)
                    {
                        DateTime oldDay = book.BorrowedAt; //반납하기 전에, 이 책이 언제 반납한건지 날짜 받아옴.
                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime(); //0001년 이런 값 들어감

                        dataGridView_BookManager.DataSource=null;
                        dataGridView_BookManager.DataSource=DataManager.Books;
                        DataManager.Save();

                        TimeSpan timeDiff = DateTime.Now - oldDay;//반납일이랑 빌린날을 뺀다.
                        if(timeDiff.Days > 7)
                            MessageBox.Show(book.Name+"은 연체상태로 반납");
                        else
                            MessageBox.Show(book.Name+"정상 반납");

                    }
                    else
                    {
                        MessageBox.Show("대여 상태가 아닙니다.");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서입니다!!!");
                }
            }
        }

        private void dataFileBackup(string folderName)
        {
            DirectoryInfo di = new DirectoryInfo(folderName); //folderName 에 해당하는 폴더를 찾고
            if (!di.Exists)
            {
                di.Create(); //없으면 만든다.
            }
            string fileName_book = "Books.xml";
            string fileName_user = "Users.xml";
            string sourcePath = @".";
            string targetPath = @".\" + folderName;

            //Path.Combine(sourcePath, fileName_book) 파일 경로 만들기. Combine : 합치다.
            string sourceFile = Path.Combine(sourcePath, fileName_book); //해당 경로에 파일을 적습니다.
            string destFile = Path.Combine(targetPath, fileName_book);
            //현재 쓰고 있는 파일을 복사해서 folderName 폴더 안에 붙여넣기 한 것
            File.Copy(sourceFile, destFile, true); //파일 덮어씁니다. 날짜나 시간별로 관리를 원할 경우 저장하는 파일명을 바꿔야 합니다.

            sourceFile = Path.Combine(sourcePath, fileName_user);
            destFile = Path.Combine(targetPath, fileName_user);
            //현재 쓰고 있는 파일을 복사해서 folderName 폴더 안에 붙여넣기 한 것
            File.Copy(sourceFile, destFile, true); //덮어씁니다. 날짜나 시간별로 관리를 원할 경우 저장하는 파일명을 바꿔야 합니다.
        }


        //프로그램이 켜지거나 꺼질 때의 Books와 Users를 백업
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataFileBackup("backupWhenLoad");

            }
            catch (Exception)
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                dataFileBackup("backupWhenClose");
            }
            catch (Exception)
            {

            }
        }
    }
}
