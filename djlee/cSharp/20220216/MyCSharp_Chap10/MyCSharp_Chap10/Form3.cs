using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap10
{
    public partial class Form3 : Form, IObserver
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(ISubject sub)
        {
            InitializeComponent();
            sub.registerObserver(this);
        }

        //update메소드를 폼별로 조금씩 다르게 구현함
        public void update(string value)
        {
            textBox1.Text = value + "2번째폼";
        }
    }
}
