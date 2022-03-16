using System;
using System.Collections.Generic;
using System.Windows.Forms;
using teamProject.DataManagers;
using teamProject.model;

namespace teamProject
{
    partial class DrugOrderForm : Form
    {
        public static List<DrugOrder> orders = new List<DrugOrder>();
        int n;

        static string errMsg;
        const string FORM_NAME = "약 주문 폼";
        public DrugOrderForm()
        {
            InitializeComponent();
        }

        private void DrugOrderForm_Load(object sender, EventArgs e)
        {
            foreach (var item in orders)
            {
                drugOrder_dtGridView.Rows.Add(item.drug.MedName, item.entp.entpName, item.count);
            }
        }

        private void btn_DrugOrder_Click(object sender, EventArgs e)
        {
            foreach (var item in orders)
            {
                new UI.EmailForm(item).ShowDialog();
            }

            foreach (var item in orders)
            {
                foreach (var item2 in DataManager.drugs)
                {
                    if (item.drug == item2)
                    {
                        item2.Stock += item.count;
                    }
                }
            }
            DataManager.Save();
            MessageBox.Show("주문 완료!!", "주문 완료");
            Close();
        }

        private void drugOrder_dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                n = drugOrder_dtGridView.CurrentCell.RowIndex;
                DrugOrder drugorder = orders[n];
                productName_txtBox.Text = drugorder.drug.MedName;
                ProductCnt_txtBox.Text = drugorder.count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("해당 인덱스에 값이 없습니다.");
                errMsg = $"[폼 위치 : {FORM_NAME}] [ex.Message] : {ex.Message}, \n[ex.StackTrace] : {ex.StackTrace}\n";
                Printlog.printLog(errMsg, DateTime.Now.ToString("yyyy_MM_dd"));
            }
        }

        private void btn_DrugCntEdit_Click(object sender, EventArgs e)
        {
            drugOrder_dtGridView.Rows.Clear();
            DrugOrder temp = orders[n];
            temp.drug.MedName = productName_txtBox.Text;
            temp.count = int.Parse(ProductCnt_txtBox.Text);

            try
            {
                foreach (var item in orders)
                {
                    drugOrder_dtGridView.Rows.Add(item.drug.MedName, item.entp.entpName, item.count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("추가 불가");
                errMsg = $"[폼 위치 : {FORM_NAME}] [ex.Message] : {ex.Message}, \n[ex.StackTrace] : {ex.StackTrace}\n";
                Printlog.printLog(errMsg, DateTime.Now.ToString("yyyy_MM_dd"));
            }
        }
    }
}

