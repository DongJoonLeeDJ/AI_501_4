using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AfterProjectPresentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff");
            listBox1.Items.Add(time);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string timeText = DateTime.Now.ToString("yyyy-MM-dd") + "일";
            listBox1.Items.Insert(0,timeText);  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mytext = DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss.fff]")+textBox1.Text;
            listBox1.Items.Insert(0,mytext);

            //특정 경로저장
            //exe 파일이 있는 곳에 폴더를 만들거나 그 폴더 안에 파일 기록 예정
            //using System.io 해줘야 빨간 줄 제거됨
            DirectoryInfo di = new DirectoryInfo("MyFolder");
            if(!di.Exists) //폴더가 없을 경우
            {
                di.Create(); //경로 생성(=폴더 생성)
            }
            using(StreamWriter writer = new StreamWriter("MyFolder\\History.log", true))
            {
                writer.WriteLine(mytext);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "http://apis.data.go.kr/1470000/DURPrdlstInfoService/getDurPrdlstInfoList?serviceKey=I35xhBVrKuRe7RbiQpN9NOkt%2B6JQT5Fd0fgCNDuB0dURcjnYRTmTeyrFaNHFDHVY%2FQ4etMclK24pY%2FdEMx2fGQ%3D%3D&pageNo=1&numOfRows=3";
            url = "http://apis.data.go.kr/1470000/DURPrdlstInfoService/";//기본 url
            string apiKey = "I35xhBVrKuRe7RbiQpN9NOkt%2B6JQT5Fd0fgCNDuB0dURcjnYRTmTeyrFaNHFDHVY%2FQ4etMclK24pY%2FdEMx2fGQ%3D%3D";
            string itemName = "테트라";
            string entpName = "종근";
            string option = "pageNo=1&numOfRows=10";
            string menu = "getDurPrdlstInfoList";

            url = $"{url}{menu}?ServiceKey={apiKey}&entpName={entpName}&itemName={itemName}&{option}";
            
            XElement element = XElement.Load(url);
            Console.WriteLine(element.ToString());
            List<Drug> drugs = new List<Drug>();    
            foreach(var item in element.Descendants("item"))
            {
                drugs.Add(new Drug(item.Element("ITEM_NAME").Value, item.Element("ENTP_NAME").Value));
               // Console.WriteLine(item.Element("ITEM_NAME").Value);
               // Console.WriteLine(item.Element("ENTP_NAME").Value);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = drugs;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = 990;
            List<Lotto> lottos = new List<Lotto>();
            while(true)
            {//990회차부터 끝까지 계속 가져오겠다.
                var json = new WebClient().DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo="+count);
                count++;
                var jArray = JObject.Parse(json);
                if (jArray["returnValue"].ToString() == "fail")
                    break;
                Console.WriteLine(jArray.ToString());

                Lotto l = new Lotto();
                l.drwtNo1 = jArray["drwtNo1"].ToString();
                l.drwtNo2 = jArray["drwtNo2"].ToString();
                l.drwtNo3 = jArray["drwtNo3"].ToString();
                l.drwtNo4 = jArray["drwtNo4"].ToString();
                l.drwtNo5 = jArray["drwtNo5"].ToString();
                l.drwtNo6 = jArray["drwtNo6"].ToString();
                l.bnusNo = jArray["bnusNo"].ToString();
                l.drwNo = jArray["drwNo"].ToString();
                l.drwNoDate = jArray["drwNoDate"].ToString();
                lottos.Add(l);
            }

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lottos;
        }
    }
}
