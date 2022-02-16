using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap10_datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Product> products = new List<Product>();
        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.name = textBox1.Text;
            product.description = textBox2.Text;
            products.Add(product);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.name = textBox3.Text;
            product.description = textBox4.Text;

            bindingSource1.Add(product);
        }
    }
}
