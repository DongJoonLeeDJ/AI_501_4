using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_from_06_02
{
    public class MyProduct
    {
        public static int Count { get; set; } //제품 개수

        //정적 생성자.
        //MyProduct의 static 변수(=클래스 변수)에 접근하거나
        //인스턴스 변수에 접근하는 등
        //MyProduct랑 연관있는 것에 접근시 호출됨
        //이건 인스턴스 만들 때 호출되는 거 아님!!!
        static MyProduct()
        {
            Console.WriteLine("안녕, 이건 MyProduct에 접근할 때 그 때 호출되는 친구야.");
        }

        //내부적(=암묵적)으로 자동으로 생성되어 있는 빈(Empty) 생성자
        public MyProduct()
        {

        }


        //C# 스타일 getter setter 1
        private string barcodeNum; //제품 고유 번호
        public string BarcodeNum { get { return barcodeNum; } set { barcodeNum = value; } }

        //c# 스타일 getter setter 2(위의 코드를 훨씬 더 간추린 형태)
        public string Name { get; set; }
        public int Price { get; set; }

        public string Description; //제품 설명.


        //datagridview 에서 MyProduct를 dataSource로 할 때!!!
        //get; set;이 있는 건 나타나고, 없는 건 안 보임


    }
}
