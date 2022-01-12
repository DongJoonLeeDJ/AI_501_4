using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp04_00_List
{
    public partial class Form1 : Form
    {

        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
            btn_list_study.Text = "안녕";
        }

        private void btn_list_study_Click(object sender, EventArgs e)
        {
            //자바의 ArrayList랑 C#의 List가 유사하다.
            List<int> numbers = new List<int>();
            numbers.Add(1000);
            numbers.Add(-1000);
            numbers.Sort();
            numbers.Remove(1000); //값이 1000인걸 삭제함
            MessageBox.Show("Test"+numbers[0]); //배열처럼 접근가능함.(자바에선 안 됐던 걸로 기억함)
            foreach (var item in numbers)
            {
                //item+"" 이랑 item.ToString()이랑 사실상 똑같은 코드
                //+ 연산이 "" 즉 문자열 만나면 그뒤부터는 문자열로써 취급
                //즉 10+100 = 110 이지만, ""+10+100 하면 10100이 됨.
                MessageBox.Show(item+""); //-1000, 1000 이렇게 정렬된 걸 하나씩 출력
            }
            MessageBox.Show(10+100+"");
            MessageBox.Show(""+10+100);

            //참고로 C#의 ArrayList는 좀 다름
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add("가즈아");
            a.Add(numbers);
            MessageBox.Show(""+a[0]+a[1]+a[2]);

        }
    }
}
