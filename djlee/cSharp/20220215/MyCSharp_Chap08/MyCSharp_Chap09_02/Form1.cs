using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap09_02
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();   
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = textBox1.Text;
            product.Price = int.Parse(textBox2.Text);
            products.Add(product);
        }

        //products에 있는 것들을 정렬해서(Sort) 출력
        private void button2_Click(object sender, EventArgs e)
        {
            products.Sort(); //에러날 것! -> IComparable 추가 후에는 잘 됨!
            string list = "";
            foreach (Product product in products)
            {
                list += "제품명 : " + product.Name + " 가격 : " + product.Price + Environment.NewLine;
            }
            label3.Text = list;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.naver.com");
            //Process.Start(@"D:\DJ\AI_501_4\djlee\cSharp\강의자료\실제 강의시 사용한 자료들\7\문제.pptx");
        }
    }
}
