using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace AfterProjectPresentation
{
    public class KakaoAPI //카카오 API 접근용
    {
        public static List<Locale> Search(string keyword)
        {
            List<Locale> list = new List<Locale>();

            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query = $"{site}?query={keyword}";
            WebRequest request = WebRequest.Create(query);

            string rKey = "c1dcc57f4d9ad1ed79b5d05a9e9be80d";//rest api 키
            string Header = "KakaoAK" + " " + rKey;//첫글자 대문자. 대소문자 유의해야함
            request.Headers.Add("Authorization", Header);

            //응답을 읽어와야 함
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            //dynamic 자바스크립트의 var나 let이랑 똑같음
            //변수 타입이 계속 바뀔 수 있는 형태
            //C#의 var는 한 번 타입 정하면 바꿀 수 없음(참고)
            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;
            int length = buf.Length;

            for(int i = 0; i<length; i++)
            {
                string lname = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                list.Add(new Locale(lname, y, x));
            }

            return list;
        }
    }
}
