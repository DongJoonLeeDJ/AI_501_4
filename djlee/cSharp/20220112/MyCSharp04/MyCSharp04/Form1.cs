using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";

            Button button1 = new Button();
            button1.Location = new Point(50, 50);
            Controls.Add(button1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //랜덤한 7개의 숫자를 뽑는다. 단 이 7개는 서로 중복되면 안 됨.
            int[] lotto = new int[7];
            //i<7 이렇게 적어도 되긴 함.
            for(int i = 0; i < lotto.Length;i++)
            {
                //int num = new Random().Next(45) + 1;
                Random random = new Random();
                int num = random.Next(45) + 1;
                if (lotto.Contains(num)) //이미 존재한다면... i값을 깎는다. 그러면 다음 단계에서 i가 원상복구됨
                    i--;
                else
                    lotto[i] = num; 
            }
            Array.Sort(lotto);

            //이 숫자들을 Label에 적용함
            label1.Text = lotto[0].ToString();
            label2.Text = lotto[1].ToString();
            label3.Text = lotto[2].ToString();
            label4.Text = lotto[3].ToString();
            label5.Text = lotto[4].ToString();
            label6.Text = lotto[5].ToString();
            label7.Text = lotto[6].ToString();

            //Label에 적혀있는 숫자에 따라서, 값을 바꿈
            if(lotto[0]<=10)
            {
                label1.ForeColor = Color.Yellow;
            }
            else if(lotto[0]<=20)
            {
                label1.ForeColor = Color.Blue;
            }
            else if(lotto[0]<=30)
            {
                label1.ForeColor = Color.Red;
            }
            else if(lotto[0]<=40)
            {
                label1.ForeColor = Color.Black;
            }
            else
            {
                label1.ForeColor = Color.Green;
            }

            Label[] labels = { label1, label2, label3, label4, label5, label6, label7 };

                for(int i = 0; i< labels.Length; i++)
                {
                    labels[i].BackColor = Color.Transparent; //투명
                    if (lotto[i] <= 10)
                    {
                        labels[i].ForeColor = Color.Yellow;
                        labels[i].BackColor = Color.Blue;
                    }
                    else if (lotto[i] <= 20)
                    {
                        labels[i].ForeColor = Color.Blue;
                    }
                    else if (lotto[i] <= 30)
                    {
                        labels[i].ForeColor = Color.Red;
                    }
                    else if (lotto[i] <= 40)
                    {
                        labels[i].ForeColor = Color.Black;
                    }
                    else
                    {
                        labels[i].ForeColor = Color.Green;
                    }

            }
        }
    }
}
