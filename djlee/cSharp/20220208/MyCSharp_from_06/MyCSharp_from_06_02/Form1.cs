using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_from_06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Product p2 = new Product(); //이건 현재 왜 안 될까?(Product 클래스 참고)
            Product p = new Product(textBox1.Text, int.Parse(textBox2.Text));
            MyProduct p3 = new MyProduct();

            label3.Text = p.Name + " 제품은 " + p.Price + "원 입니다.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyProduct.Count = int.Parse(textBox3.Text);
            //참고로 지금 출력하는 거 없음...
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //상수는 대문자로 적음
            //항상 변하지 않음
            const double DOLLOR = 1197.28;
            //DOLLOR = 1000;
            Product p = new Product();
            p.Price = 10000;

            label5.Text = (p.Price / DOLLOR) + "달러";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyProduct p = new MyProduct();
            p.Name = textBox_name.Text;
            p.Price = int.Parse(textBox_price.Text);
            p.BarcodeNum = textBox_barcode.Text; //barcodeNum 이라는 private 변수에 값을 넣은 것(set)
            p.Description = textBox_description.Text;
            //barcodeNum이라는 private 변수의 값을 읽어들인 것 (get)
            label_info.Text = $"{p.Name}은 {p.Price}원이고, 고유번호는 {p.BarcodeNum}이다. 주의사항은 {p.Description}이다.";

        }
    }
}
