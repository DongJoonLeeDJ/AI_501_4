using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterProjectPresentation
{
    public class Locale
    {
        public string Name { get; set; } //위치 이름
        public double Lat { get; set; } //위치의 좌표 (y)
        public double Lng { get; set; } //위치의 좌표 (x)

        public Locale(string name, double lat, double lng)
        {
            Name = name;
            Lat = lat;
            Lng = lng;
        }

        //모든 클래스의 조상인 Object의 ToString을 오버라이딩함
        public override string ToString()
        {
            return Name;
            //return base.ToString(); //조상이 가지고 있는 ToString을 그대로 활용하겠다.
        }
    }
}
