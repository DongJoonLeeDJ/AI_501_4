using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myanswer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var item in Controls)
            {
                if(item is Button)
                {
                    var btn = (Button)item;
                    btn.Text = btn.Text.Replace("button", "");
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                foreach (var item in Controls)
                {
                    if (item is Button)
                    {
                        var btn = (Button)item;
                        btn.Text = btn.Name.Replace("button", "");
                    }
                }

                var b = (sender as Button);//누른 것의 텍스트만 ""으로 한다.
                b.Text = "";

            }
        }
    }
}
