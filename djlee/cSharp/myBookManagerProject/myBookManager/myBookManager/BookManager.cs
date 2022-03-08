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
    public partial class BookManager : Form
    {
        public BookManager()
        {
            InitializeComponent();
            if (DataManager.Books.Count > 0)
                dataGridView_books.DataSource = DataManager.Books;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //책을 추가하기 전에 해당하는 isbn이 있는지 여부 체크
            bool existBook = false;
            foreach(var item in DataManager.Books)
            {
                if(item.Isbn == textBox_isbn.Text)
                {
                    existBook = true;
                    break;
                }
            }
            if(existBook)
                MessageBox.Show("이미 존재하는 도서입니다.");
            else //책을 새로 등록할 수 있음
            {
                Book book = new Book();
                book.Isbn = textBox_isbn.Text;
                book.Name = textBox_bookName.Text;
                book.Publisher = textBox_publisher.Text;
                book.Page = int.Parse(textBox_page.Text);
                DataManager.Books.Add(book);

                dataGridView_books.DataSource = null;
                dataGridView_books.DataSource = DataManager.Books;
                DataManager.Save();
            }


        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            Book book = null;
            for(int i = 0; i<DataManager.Books.Count; i++)
            {
                if(DataManager.Books[i].Isbn == textBox_isbn.Text)
                {
                    book = DataManager.Books[i];
                    book.Name = textBox_bookName.Text;
                    book.Publisher = textBox_publisher.Text;
                    book.Page = int.Parse(textBox_page.Text);

                    dataGridView_books.DataSource = null;
                    dataGridView_books.DataSource = DataManager.Books;
                    DataManager.Save();
                    break;
                }
            }
            if(book == null)
                MessageBox.Show("존재하지 않는 도서입니다.");

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            for(int i = 0; i<DataManager.Books.Count; i++)
            {
                if(DataManager.Books[i].Isbn == textBox_isbn.Text)
                {
                    DataManager.Books.RemoveAt(i);
                    existBook = true;
                    break;
                }
            }
            if(existBook == false)
                MessageBox.Show("없는 책입니다.");
            else
            {
                dataGridView_books.DataSource=null;
                if (DataManager.Books.Count > 0)
                    dataGridView_books.DataSource = DataManager.Books;
                DataManager.Save();
            }
        }

        private void dataGridView_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = dataGridView_books.CurrentRow.DataBoundItem as Book;
            textBox_isbn.Text = book.Isbn;
            textBox_bookName.Text = book.Name;
            textBox_publisher.Text = book.Publisher;
            textBox_page.Text = book.Page.ToString();
        }
    }
}