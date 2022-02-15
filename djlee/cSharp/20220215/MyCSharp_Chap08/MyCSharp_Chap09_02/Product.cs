using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap09_02
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }


        //Sort를 호출하면 CompareTo가 내부적으로 호출되서 List안에 있는 값끼리 서로 비교함
        //음수 : other보다 작다.
        //0 : 똑같다.
        //양수 : other보다 크다
        public int CompareTo(Product other)
        {
            return Price.CompareTo(other.Price); //int자료형에 있는 CompareTo를 통해서 Product 객체를 서로 비교
        }

        //public int CompareTo(object obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
