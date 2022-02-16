using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap10_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = a * a;
                MessageBox.Show("a의 제곱은 " + b + "이다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외발생!");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                return;
            }
            finally //finally를 주석처리하고, 예외가 발생하게 되면 catch의 return에서 끝난다.
            {
                MessageBox.Show("catch로 빠지든 빠지지 않든 이 부분은 무 조 건 실행함(catch안에 return있어도 마찬가지)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                MessageBox.Show("a="+a);
            }
            catch (FormatException ex) //FormatException에 대해서만 catch한다.
            {
                MessageBox.Show("형식잘못됨");
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            catch(OverflowException ex) //OverflowException 대해서만 catch한다.
            {
                MessageBox.Show("숫자가 너무 크거나 작음 ㅡㅡ");
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            catch (Exception ex) //모든 Exception에 대해서 catch한다.
            {
                MessageBox.Show("또 다른 에러.");
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool error = int.TryParse(textBox1.Text, out int value); //내가 아무리 이상한 걸 써도 value에는 0 들어가고 에러 발생 안 함

                if(error==false)
                    throw new Exception("입력 형식이 잘못된 것 같습니다.");

                MessageBox.Show("텍스트박스1의 숫자는 " + value + "입니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외발생");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
