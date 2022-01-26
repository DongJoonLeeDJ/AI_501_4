using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfterProjectPresentation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Locale> locales = KakaoAPI.Search(textBox1.Text);
            listBox1.Items.Clear();
            foreach (Locale item in locales)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //해당 키워드 클릭시 해당 위치 띄우기
            if (listBox1.SelectedIndex == -1) //인덱스값 잘못들어가는 거 방지
                return;

            Locale ml = listBox1.SelectedItem as Locale;
            object[] pos = new object[] {ml.Lat, ml.Lng};
            HtmlDocument hdoc = webBrowser1.Document;
            hdoc.InvokeScript("setCenter", pos);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                button1.PerformClick(); //엔터치면 버튼 1 클릭
        }
    }
}
