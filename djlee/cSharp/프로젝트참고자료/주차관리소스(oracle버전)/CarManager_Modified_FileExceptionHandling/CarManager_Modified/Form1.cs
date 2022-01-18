using System;
using System.Windows.Forms;

namespace CarManager_Modified
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataManager.selectQuery();
            refreshScreen();
            /*
             
INSERT INTO "C##SCOTT"."TABLE1" (PARKINGSPOT, CARNUMBER, DRIVERNAME, PHONENUMBER) VALUES ('1', '10구1234', '이동준', '010-2940-1613')
INSERT INTO "C##SCOTT"."TABLE1" (PARKINGSPOT, CARNUMBER, DRIVERNAME, PHONENUMBER) VALUES ('2', '10고1234', '이동호', '010-2940-1614')
INSERT INTO "C##SCOTT"."TABLE1" (PARKINGSPOT, CARNUMBER, DRIVERNAME, PHONENUMBER) VALUES ('3', '10구4321', '김동준', '010-2940-1615')
INSERT INTO "C##SCOTT"."TABLE1" (PARKINGSPOT, CARNUMBER, DRIVERNAME, PHONENUMBER) VALUES ('4', '11구1234', '최동준', '010-2940-1616')
INSERT INTO "C##SCOTT"."TABLE1" (PARKINGSPOT, CARNUMBER, DRIVERNAME, PHONENUMBER) VALUES ('5', '12구1234', '박명회', '010-2940-1617')

             */
        }

        void refreshScreen()
        {

            try
            {

                
                dataGridView_parkingManager.DataSource = null;
                if (DataManager.parkingCars.Count > 0)
                {

                    dataGridView_parkingManager.DataSource = DataManager.parkingCars;
                    textBox_parkingSpot.Text = DataManager.parkingCars[0].ParkingSpot.ToString();
                    textBox_carNumber.Text = DataManager.parkingCars[0].CarNumber;
                    textBox_driverName.Text = DataManager.parkingCars[0].DriverName;
                    textBox_phoneNumber.Text = DataManager.parkingCars[0].PhoneNumber;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.StackTrace);
                //throw;
            }
        }

        private void button_parkingAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //공간번호 입력 필수
                if (textBox_parkingSpot.Text.Trim() == "")
                {
                    MessageBox.Show("주차공간을 입력해주세요.");
                }
                //차량번호 입력 필수
                else if (textBox_carNumber.Text.Trim() == "")
                {
                    MessageBox.Show("차량 번호를 입력해주세요.");
                }
                else
                {
                    try
                    {
                        //이미 해당 공간에 차가 있는 경우에는 안 된다고 하기
                        ParkingCar car = DataManager.selectQuery(int.Parse(textBox_parkingSpot.Text)); //1칸짜리 List 반환됨

                        if (car.CarNumber.Trim() != "")
                        {
                            MessageBox.Show("해당 공간에는 이미 차가 존재합니다.");
                        }
                        else
                        {
                            DataManager.executeQuery("update", textBox_parkingSpot.Text, textBox_carNumber.Text, textBox_driverName.Text, textBox_phoneNumber.Text);
                            //DataManager.selectQuery(); //전체 조회

                            dataGridView_parkingManager.DataSource = null;
                            dataGridView_parkingManager.DataSource = DataManager.parkingCars;

                            string contents = $"주차 공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text}차를 주차하였습니다.";

                            //이 두 줄과 아래 한 줄은 같은 기능
                            //DataManager.PrintLog(contents);
                            //MessageBox.Show(contents);

                            WriteLog(contents);
                        }

                    }
                    catch (Exception)
                    {
                        //아예 없는 주차공간일 경우
                        string contents = $"주차할 수 없습니다. 주차공간 {textBox_parkingSpot.Text} 은(는) 존재하지 않습니다.";
                        MessageBox.Show(contents);
                    }
                }
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.StackTrace);
                //throw;
            }
        }

        private void button_parkingRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //차량번호나 공간번호 입력 필수
                if (textBox_parkingSpot.Text.Trim() == "")
                {
                    MessageBox.Show("주차공간을 입력해주세요.");
                }
                else//존재하지 않은 경우에 알람(add와 반대)
                {
                    try
                    {
                        //해당 공간에 차가 아직 없는 경우에는 안 된다고 하기
                        //ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingSpot.Text.ToString());

                        ParkingCar car = DataManager.selectQuery(int.Parse(textBox_parkingSpot.Text)); //1칸짜리 List 반환됨
                        if (car.CarNumber.Trim() == "")
                        {
                            MessageBox.Show("해당 공간에는 아직 주차된 차가 없습니다.");
                        }
                        else
                        {
                            //참조 복사를 사용하므로, car의 속성이 바뀌면 Cars에 있는 해당 속성들이 바뀐다.
                            string oldcar = car.CarNumber;
                            DataManager.executeQuery("update", textBox_parkingSpot.Text, "", "", "");
                            //DataManager.selectQuery(); //전체 조회

                            dataGridView_parkingManager.DataSource = null;
                            dataGridView_parkingManager.DataSource = DataManager.parkingCars;
                            string contents = $"{oldcar}차를 주차 공간 {textBox_parkingSpot.Text}에서 출차하였습니다.";

                            //이 두 줄과 아래 한 줄은 같은 기능
                            //DataManager.PrintLog(contents);
                            //MessageBox.Show(contents);

                            WriteLog(contents);
                        }

                    }
                    catch (Exception ex)
                    {
                        //아예 없는 주차공간일 경우
                        string contents = $"출차할 수 없습니다. 주차공간 {textBox_parkingSpot.Text} 은(는) 존재하지 않습니다.";
                        MessageBox.Show(contents);
                        MessageBox.Show(ex.StackTrace);
                        MessageBox.Show("List의 길이 "+DataManager.parkingCars.Count);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.StackTrace);
            }


        }

        private void button_SelectedLookUp_Click(object sender, EventArgs e)
        {

            try
            {
                int parkingSpot = int.Parse(textBox_parkingSpot_lookUp.Text);
                DataManager.selectQuery(parkingSpot);
                string ParkedCar = DataManager.parkingCars[0].CarNumber;
                if (ParkedCar != "")
                {
                    string contents = $"주차공간 {textBox_parkingSpot_lookUp.Text}에 주차되어 있는 차는 {ParkedCar}입니다.";

                    //이 두 줄과 아래 한 줄은 같은 기능
                    //DataManager.PrintLog($"주차공간 {textBox_carNumber_lookUp.Text}에 주차되어 있는 차는 {ParkedCar}입니다.");
                    //MessageBox.Show($"주차공간 {textBox_carNumber_lookUp.Text}에 주차되어 있는 차는 {ParkedCar}입니다.");

                    WriteLog(contents);
                }
                else
                {
                    string contents = $"주차공간 {textBox_parkingSpot_lookUp.Text}에 주차된 차가 없습니다.";

                    //이 두 줄과 아래 한 줄은 같은 기능
                    //DataManager.PrintLog($"주차공간 {textBox_carNumber_lookUp.Text}에 주차된 차가 없습니다.");
                    //MessageBox.Show($"주차공간 {textBox_carNumber_lookUp.Text}에 주차된 차가 없습니다.");

                    WriteLog(contents);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("주차공간번호가 유효하지 않습니다.");
            }

        }


        private void timer_DisplayNowtime_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Now.Text = "현재 시간 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void dataGridView_parkingManager_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                ParkingCar car = dataGridView_parkingManager.CurrentRow.DataBoundItem as ParkingCar;

                textBox_parkingSpot.Text = car.ParkingSpot.ToString();
                textBox_parkingSpot_lookUp.Text = car.ParkingSpot.ToString();
                textBox_carNumber.Text = car.CarNumber;
                textBox_driverName.Text = car.DriverName;
                textBox_phoneNumber.Text = car.PhoneNumber;

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.StackTrace);
            }
        }

        private void WriteLog(string contents)
        {
            string logContents = "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + contents; //연/월/일 시:분:초 형식으로 로그찍기
            DataManager.PrintLog(logContents);
            MessageBox.Show(contents);
            listBox_logPrint.Items.Insert(0, logContents);
        }

        private void button_insert_parkingspot_Click(object sender, EventArgs e)
        {
            DataManager.executeQuery("insert", textBox_parkingSpot_lookUp.Text);
            refreshScreen();
        }

        private void button_delete_parkingspot_Click(object sender, EventArgs e)
        {
            DataManager.executeQuery("delete", textBox_parkingSpot_lookUp.Text);
            refreshScreen();
        }
    }
}
