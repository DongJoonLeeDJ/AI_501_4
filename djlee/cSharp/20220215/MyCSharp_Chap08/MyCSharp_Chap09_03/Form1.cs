using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap09_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info = "";
            //내가 체크한 것들 띄우기 첫번째 방법(1번째나 2번째만 선택하면 끝에 콤마가 남는다)
            //if (checkBox1.Checked)
            //    info += checkBox1.Text + ",";
            //if(checkBox2.Checked)
            //    info += checkBox2.Text + ",";
            //if (checkBox3.Checked)
            //    info += checkBox3.Text;

            //2번째 방법
            List<string> infolist = new List<string>();
            //if (checkBox1.Checked)
            //    infolist.Add(checkBox1.Text);
            //if (checkBox2.Checked)
            //    infolist.Add(checkBox2.Text);
            //if (checkBox3.Checked)
            //    infolist.Add(checkBox3.Text);

            //info = string.Join(",", infolist);

            //3번째 방법 : Control에서 checkBox를 찾고, 그게 체크되어 있으면 추가하는 방식
            foreach (var item in Controls)
            {
                if(item is CheckBox)//만약 체크박스라면...
                {
                    if( (item as CheckBox).Checked ) //그리고 체크가 되어 있다면
                        infolist.Add((item as CheckBox).Text); //그 체크박스의 텍스트를 infolist에 추가
                }
            }
            info = string.Join(",", infolist);

            MessageBox.Show(info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> infolist = new List<string>();

            foreach (var item in Controls)
            {
                if(item is GroupBox)
                {
                    GroupBox groupBox = item as GroupBox;

                    foreach (var in_item in groupBox.Controls)
                    {
                        if(in_item is RadioButton)
                        {
                            RadioButton r = in_item as RadioButton;
                            if(r.Checked)
                                infolist.Add(r.Text);
                        }
                    }
                }
            }

            string result = string.Join(",", infolist);
            MessageBox.Show(result);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> infolist = new List<string>();
            string info = "";

            foreach (var item in Controls)
            {
                if (item is CheckBox)//만약 체크박스라면...
                {
                    if ((item as CheckBox).Checked) //그리고 체크가 되어 있다면
                        infolist.Add((item as CheckBox).Text); //그 체크박스의 텍스트를 infolist에 추가
                }

                if (item is GroupBox)
                {
                    GroupBox groupBox = item as GroupBox;

                    foreach (var in_item in groupBox.Controls)
                    {
                        if (in_item is RadioButton)
                        {
                            RadioButton r = in_item as RadioButton;
                            if (r.Checked)
                                infolist.Add(r.Text);
                        }
                    }
                }
            }

            info = string.Join(",", infolist);
            MessageBox.Show(info);
        }
    }
}
