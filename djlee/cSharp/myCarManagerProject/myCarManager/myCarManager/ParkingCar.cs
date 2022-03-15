using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCarManager
{
    public class ParkingCar
    {
        public int ParkingSpot { get; set; } //주차 공간 번호(기본키,pk)
        public string CarNumber { get; set; } //자동차 번호
        public string DriverName { get; set; } //운전자 이름
        public string PhoneNumber { get; set; } //운전자 연락처
        public DateTime ParkingTime { get; set; } //주차 시점

    }
}
