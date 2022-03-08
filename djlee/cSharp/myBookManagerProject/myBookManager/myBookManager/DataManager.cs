using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace myBookManager
{
    public class DataManager
    {
        //책들 정보, 유저들 정보를 List에 저장하고 관리
        //책에 대한 List는 1개, 유저에 대한 리스트도 1개
        //따라서 static으로 선언.

        //static 특징
        //클래스이름.Books 이런식으로 접근 가능
        //DataManager 클래스가 공통적으로 접근 가능
        //메모리 영역중에서 데이터영역이라는 곳에 할당됨. 즉 프로그램 
        //시작하자 마자 할당됨.

        //static이 없는 것들은 new 클래스명과 같은 생성자를 호출할 때 메모리 할당됨.
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        //접근제한자(public 등)이 생략되면 private이 자동으로 들어감
        //컬럼명, 테이블(=객체)명을 상수로 저장해서 가독성을 올리고, 오타를 방지
        
        /// <summary>
        /// 객체명
        /// </summary>
        const string BOOK = "book";
        const string USER = "user";

        /// <summary>
        /// 도서용
        /// </summary>
        const string ISBN = "isbn";
        const string NAME = "name";
        const string PUBLISHER = "publisher";
        const string PAGE = "page";
        const string ISBORROWED = "isBorrowed";
        const string BORROWEDAT = "borrowedAt";
        const string USERID = "userId";
        const string USERNAME = "username";

        /// <summary>
        /// 유저용
        /// </summary>
        const string UNAME = "name";
        const string UID = "id";


        //정적 생성자 = static 생성자
        //new DataManager()할 때 호출되지 않음
        //DataManager 자체에 접근할 때 호출됨
        //이 생성자는 프로그램 시작하자마자 메모리에 올라와 있다.
        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                //Books.xml 파일을 읽어들임
                string booksOutput = File.ReadAllText(@"./Books.xml");
                //Booksxml에 있는 글자들을 읽어 들여서 XElement형태로 변환
                XElement BooksXElement = XElement.Parse(booksOutput);

                //Descendants 자손들
                //태그명이 book인 것들을 모은 것
                //Books.xml은 books 태그 안에 여러 개의 book 태그가 있는 형태
                Books = (from item in BooksXElement.Descendants(BOOK)
                         select new Book()
                         {
                             Isbn = item.Element(ISBN).Value,
                             Name = item.Element(NAME).Value,
                             Publisher = item.Element(PUBLISHER).Value,
                             Page = int.Parse(item.Element(PAGE).Value),
                             UserId = int.Parse(item.Element(USERID).Value),
                             UserName = item.Element(USERNAME).Value,
                             BorrowedAt = DateTime.Parse(item.Element(BORROWEDAT).Value),
                             isBorrowed = item.Element(ISBORROWED).Value != "0" ? true : false
                         }).ToList<Book>();

                //foreach문 써보기(LINQ는 Books 부터 .ToList<Book>();까지를 한 줄로 봐서 디버깅이 매우 어려움)
                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users.Clear();
                foreach(var item in usersXElement.Descendants(USER))
                {
                    User temp = new User();
                    temp.Name = item.Element(UNAME).Value;
                    temp.Id = int.Parse(item.Element(UID).Value);
                    Users.Add(temp);
                }

            }
            catch (Exception e)
            {
                //파일이 없으면 이 부분으로 빠지게 되고, 파일을 다시 읽어들임.
                Save(); //만약 Save 실패시 StackOverFlow 에러에 걸림
                Load(); 
            }
        }

        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<books>\n";

            foreach(var item in Books)
            {
                booksOutput += $"\t<{BOOK}>\n";
                booksOutput += $"\t\t<{ISBN}> {item.Isbn}</{ISBN}>\n";
                booksOutput += $"\t\t<{NAME}> {item.Name} </{NAME}>\n";
                booksOutput += $"\t\t<{PUBLISHER}> {item.Publisher}</{PUBLISHER}>\n";
                booksOutput += $"\t\t<{PAGE}> {item.Page} </{PAGE}>\n";
                booksOutput += $"\t\t<{BORROWEDAT}> {item.BorrowedAt} </{BORROWEDAT}>\n";
                booksOutput += $"\t\t<{ISBORROWED}>" + (item.isBorrowed ? 1 : 0) + $"</{ISBORROWED}>\n";
                booksOutput += $"\t\t<{USERID}> {item.UserId} </{USERID}>\n";
                booksOutput += $"\t\t<{USERNAME}> {item.UserName} </{USERNAME}>\n";
                booksOutput += $"\t</{BOOK}>\n";
            }

            booksOutput += "</books>";
            Console.WriteLine(booksOutput);
            File.WriteAllText(@"./Books.xml", booksOutput); //xml파일에 값 넣는 것


            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach(var item in Users)
            {
                usersOutput += $"\t<{USER}>\n";
                usersOutput += $"\t\t<{UID}>{item.Id}</{UID}>\n";
                usersOutput += $"\t\t<{UNAME}>{item.Name}</{UNAME}>\n";
                usersOutput += $"\t</{USER}>\n";
            }
            usersOutput += "</users>";
            Console.WriteLine(usersOutput);
            File.WriteAllText(@"./Users.xml", usersOutput);
        }
    } 
}
