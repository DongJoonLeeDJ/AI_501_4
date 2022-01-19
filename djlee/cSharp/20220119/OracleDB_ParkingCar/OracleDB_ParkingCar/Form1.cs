using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleDB_ParkingCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataManager.selectQuery(); //db 접속해서 select문 날린 후, cars에 값 넣고
            refreshScreen(); //그 cars에 있는 걸 화면에 뿌림
        }

        void refreshScreen()
        {
            dataGridView_parkingcar.DataSource = null;
            try
            {
                if(DataManager.cars.Count > 0)
                {
                    dataGridView_parkingcar.DataSource = DataManager.cars;
                    //cars에 있는 가장 첫번째 값을 textbox들에 뿌려주는 것
                    textBox_parkingspot.Text = DataManager.cars[0].ParkingSpot.ToString();
                    textBox_parkingspot_manager.Text = textBox_parkingspot.Text;
                    textBox_carnumber.Text = DataManager.cars[0].CarNumber;
                    textBox_drivername.Text = DataManager.cars[0].DriverName;
                    textBox_phonenumber.Text = DataManager.cars[0].PhoneNumber;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_park_in_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox_parkingspot.Text == "") //주차공간을 누락시킨 경우
                {
                    MessageBox.Show("주차 공간 입력하세요.");
                    return;
                }
                if(textBox_carnumber.Text =="")
                {
                    MessageBox.Show("차 번호 입력하셔야죠.");
                    return;
                }
                ParkingCar car = DataManager.selectQuery(int.Parse(textBox_parkingspot.Text));

                if(car.CarNumber !="")//해당 주차공간에 CarNumber값이 존재하는 경우.
                {
                    MessageBox.Show("이미 주차됨");
                }
                else 
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
