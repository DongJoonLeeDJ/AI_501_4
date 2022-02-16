using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if(DataManager.Books.Count > 0)
                dataGridView_book.DataSource = DataManager.Books;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            bool existBook = false;

            foreach (var item in DataManager.Books)
            {
                if(item.Isbn == textBox_isbn.Text)
                {
                    existBook = true;
                    break;
                }
            }
            if(existBook)
                MessageBox.Show("이미 존재하는 도서!");
            else
            {
                Book book = new Book();
                book.Isbn = textBox_isbn.Text;
                book.Name = textBox_bookName.Text;
                book.Publisher = textBox_publisher.Text;
                book.Page = int.Parse(textBox_page.Text);
                DataManager.Books.Add(book);

                dataGridView_book.DataSource = null;
                dataGridView_book.DataSource = DataManager.Books;
                DataManager.Save();
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            Book book = null; //book은 아무데도 가리키지 않음
            for(int i = 0; i<DataManager.Books.Count; i++)
            {
                if(DataManager.Books[i].Isbn == textBox_isbn.Text)
                {
                    book = DataManager.Books[i]; //Books의 i번째를 가리키게 됨(얕은 복사 = 참조복사)
                    book.Name = textBox_bookName.Text; //book의 값이 변경되면 Books의 i번째꺼가 값이 변경됨
                    book.Publisher = textBox_publisher.Text;
                    book.Page = int.Parse(textBox_page.Text);

                    //참고 위의 코드와 같은 코드
                    //직접 i에 접근해서 바꾸는 거랑 위에꺼랑 똑같은 코드
                    /*
                     DataManager.Books[i].Name = textBox_bookName.Text;
                     DataManager.Books[i].Publisher = textBox_publisher.Text;
                     DataManager.Books[i].Page = int.Parse(textBox_page.Text);
                     */

                    dataGridView_book.DataSource = null;
                    dataGridView_book.DataSource = DataManager.Books;
                    DataManager.Save();
                }
            }
            if(book==null)
                MessageBox.Show("존재하지 않는 도서입니다.");

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            for (int i = 0; i < DataManager.Books.Count; i++)
            {
                if(DataManager.Books[i].Isbn == textBox_isbn.Text)
                {
                    DataManager.Books.RemoveAt(i);
                    existBook = true;
                }
            }
            if(existBook == false) //isbn이 1234인 책을 지우려고 봤더니 1234인 책이 없는 경우
                MessageBox.Show("없는 책입니다.");
            else
            {
                dataGridView_book.DataSource = null;
                if (DataManager.Books.Count > 0)
                    dataGridView_book.DataSource = DataManager.Books;
                DataManager.Save();
            }
        }

        private void dataGridView_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = dataGridView_book.CurrentRow.DataBoundItem as Book;
            textBox_isbn.Text = book.Isbn;
            textBox_bookName.Text = book.Name;
            textBox_publisher.Text = book.Publisher;
            textBox_page.Text = book.Page.ToString();
        }
    }
}
