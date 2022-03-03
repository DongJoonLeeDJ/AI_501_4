using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookManager
{
    public class DataManager
    {
        //우리는 싱글톤 패턴 대신에 static(클래스변수, 클래스 메소드) 활용해서
        //DataManager.Books 등으로 접근할 것임
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        //DataManager에 접근하는 그 순간 바로 호출되는 것(인스턴스 만들기 전에 생김)

        //프로그램 켜자마자 DataManager에 접근하면 바로 Load부터 한다. 즉 xml 파일부터 읽어들임
        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                //Books.xml이라는 파일을 읽어 들이고, 그 안에 있는 텍스트들을 booksOutput에 담는다.
                string booksOutput = File.ReadAllText(@"./Books.xml");
                //그 텍스트 값들을 XML 데이터 양식으로 변경.
                XElement booksXElement = XElement.Parse(booksOutput);

                //Linq Ver
                Books = (from item in booksXElement.Descendants("book")
                         select new Book()
                         {
                             Isbn = item.Element("isbn").Value,
                             Name = item.Element("name").Value,
                             Publisher = item.Element("publisher").Value,
                             Page = int.Parse(item.Element("page").Value),
                             BorrowedAt = DateTime.Parse(item.Element("borrowedAt").Value),
                             isBorrowed = item.Element("isBorrowed").Value != "0" ? true : false,
                             UserId = int.Parse(item.Element("userId").Value),
                             UserName = item.Element("userName").Value
                         }).ToList<Book>();

                //foreach Ver
                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users.Clear(); //기존에 있던 걸 싹 지우고 다시 파일에서 읽어와야 함
                foreach (var item in usersXElement.Descendants("user"))
                {
                    User temp = new User();
                    temp.Name = item.Element("name").Value;
                    temp.Id = int.Parse(item.Element("id").Value);
                    Users.Add(temp); //읽어온 내용을 Users에 담아줘야 한다.
                }



            }
            catch (Exception e) //파일을 못 읽어들이면 Save 호출 후 Load 다시 호출
            {   //만약 Load가 Save를 호출한 이후에도 Exception을 발생하면 무한 반복.
                System.Windows.Forms.MessageBox.Show("파일 누락!");
                Save();
                Load();
            }
        }

        //List에 있던 값들로 덮어쓰기를 항상 수행함.
        //예를 들어서 책 추가 삭제 반납, 유저 추가 삭제 등을 해서 각각의 List에 저장하면
        //기존의 텍스트에 있는 값들을 싹 날리고, List에 있는 것들을 하나 하나 넣는 방식
        public static void Save() //항상 기존에 있던 값들을 싹 덮어쓰는 방식을 함.
        {
            string booksOutput = "";
            booksOutput += "<books>\n";

            foreach (var item in Books)
            {
                booksOutput += "<book>\n";

                booksOutput += $"   <isbn>{item.Isbn}</isbn>\n"; 
                booksOutput += $"   <name>{item.Name}</name>\n"; 
                booksOutput += $"   <publisher>{item.Publisher}</publisher>\n"; 
                booksOutput += $"   <page>{item.Page}</page>\n"; 
                booksOutput += $"   <borrowedAt>{item.BorrowedAt}</borrowedAt>\n"; 
                booksOutput += $"   <isBorrowed>" + (item.isBorrowed ? 1 : 0) + "</isBorrowed>\n"; //빌리면1, 안빌렸으면 0
                booksOutput += $"   <userId>{item.UserId}</userId>\n"; 
                booksOutput += $"   <userName>{item.UserName}</userName>\n"; 

                booksOutput += "</book>\n";
            }

            booksOutput += "</books>";

            File.WriteAllText(@"./Books.xml", booksOutput);

            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach(var item in Users)
            {
                usersOutput += "<user>\n";
                usersOutput += $"   <id>{item.Id}</id>\n";
                usersOutput += $"   <name>{item.Name}</name>\n";
                usersOutput += "</user>\n";
            }
            usersOutput += "</users>";
            File.WriteAllText(@"./Users.xml", usersOutput);

        }

        //싱글톤 패턴
        //DataManager 타입의 변수를 단 하나만 설정해서 그걸 계속 쓰는 것.
        //private DataManager instance;
        //public DataManager getInstance()
        //{
        //    if(instance== null)
        //        instance = new DataManager();
        //    return instance;
        //}
    }
}
