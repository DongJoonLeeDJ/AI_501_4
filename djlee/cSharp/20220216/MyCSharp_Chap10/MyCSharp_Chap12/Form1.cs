using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyCSharp_Chap12
{
    public partial class Form1 : Form
    {

        List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var output = from item in numbers where item % 2 != 0 select item;
            label1.Text = "";
            string result = "";
            foreach (var item in output)
            {
                result += item;
            }
            label1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var output = from item in numbers where item % 2 == 0 select item;
            label2.Text = "";
            string result = "";
            foreach (var item in output)
            {
                result += item;
            }
            label2.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //from 내가원하는이름 in 컬렉션(list이름) select 결과에 넣을 요소(출력요소)
            //만약에 numbers에 1,2,3,4,5,6,7,8,9,10 있다.

            //from 뒤에 오는 aa는 1~10까지의 값. 즉 numbers에 있는 값들 의미
            //in 뒤에 오는 numbers는 글자 그대로 list
            //where 뒤에 오는 게 조건문이고, sql문이랑 유사
            //select 뒤에 오는 건 '출력문 혹은 결과물'

            //홀수인 숫자들을 가지고 와서 그 것의 제곱을 output에 저장
            var output = from aa in numbers where aa%2 != 0 select aa*aa;
            string result = "";
            foreach (var item in output)
            {
                result += item + " ";
            }
            label3.Text = result;
        }


        List<Product> products = new List<Product>();

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int price = int.Parse(textBox2.Text);

            products.Add(new Product() { Name = name, Price = price });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int price = int.Parse(textBox2.Text);

            products.Add(new Product() { Name = name, Price = price });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //익명 객체(Product처럼 미리 만들어 진 거 아님)
            //이 익명객체에는 itemName, doublePrice, HalfPrice라는 속성이 있다.
            //이 익명 객체는 저 linq문 안에서만 쓰임.

            //이 안에 있는 item은 Product 타입
            var output = from item in products where item.Price < 1500 select new { itemName=item.Name, doublePrice = item.Price * 2, HalfPrice = item.Price / 2 };

            string result = "";
            //이 안에 있는 item은 Product 타입 아님. 내가 만든 익명 객체 타입(itemName, doublePrice, HalfPrice라는 속성이 있다.)
            foreach (var item in output)
            {
                result += $"{item.itemName}의 두배 가격은 {item.doublePrice}, 반 값은 {item.HalfPrice}{Environment.NewLine}";
            }
            label4.Text = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var output = from item in products where item.Price < 1500 select item;
            string result = "";
            foreach (var item in output)
            {
                result += item.Name + "은 " + item.Price + "원이다." + Environment.NewLine;
            }
            label5.Text = result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string url = "http://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement myxml = XElement.Load(url); //기상청 데이터 xml을 XElement라는 타입으로 변경함
            Console.WriteLine(myxml); //이걸 콘솔창에 찍은 것
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string url = "http://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement myxml = XElement.Load(url); //기상청 데이터 xml을 XElement라는 타입으로 변경함

            //무수하게 많은 xml중에서 날짜랑 한국어날씨(맑음 등) 가져옴
            var output = from item in myxml.Descendants("data")
                         select new
                         {  Day = item.Element("day").Value,
                            weather = item.Element("wfKor").Value
                         };

            foreach (var item in output)
            {
                Console.WriteLine(item.Day+" "+item.weather);
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            string url = "http://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement myxml = XElement.Load(url); //기상청 데이터 xml을 XElement라는 타입으로 변경함

            //무수하게 많은 xml중에서 날짜랑 한국어날씨(맑음 등) 가져옴
            //Descendants : 자손들. <data> 태그의 자손들
            //data태그의 자손들을 가지고 output에 다 넣음
            //그 중에서 day랑 wfKor만 가져감
            var output = from item in myxml.Descendants("data")
                         select new Weather()
                         {
                             Day = item.Element("day").Value,
                             korWeather = item.Element("wfKor").Value
                         };

            foreach (var item in output)
            {
                Console.WriteLine(item.Day + " " + item.korWeather);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string url = "http://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement myxml = XElement.Load(url); //기상청 데이터 xml을 XElement라는 타입으로 변경함

            foreach (var item in myxml.Descendants("data")) //data태그들만 모음
            {
                Console.WriteLine(item.Element("day").Value); //data태그의 자손인 day와 wfkor의 값들만 출력
                Console.WriteLine(item.Element("wfKor").Value);
            }

            List<Weather> ws = new List<Weather>();
            foreach (var item in myxml.Descendants("data")) //data태그들만 모음
            {
                Weather w = new Weather();
                w.Day = item.Element("day").Value;
                w.korWeather = item.Element("wfKor").Value;
                ws.Add(w);
            }

            foreach (var item in ws)
            {
                Console.WriteLine(item.Day+"_"+item.korWeather);
            }

        }
    }
}
