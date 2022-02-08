using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_from_06_02
{
    public class Product
    {

        public string Name { get; set; }
        public int Price { get; set; }

        //처음엔 이거만 있었는 데...(내부적으로, 암묵적으로)
        //밑에 매개변수 있는 생성자 넣으면서 이 생성자가 사라지게 됨
        //따라서 new Product() 하고 싶으면 비어있는(매개변수가 없는) 생성자를 만들어주면 된다.
        public Product()
        {

        }

        //매개변수(=파라메터) 있는 생성자가 생기면서 new Product() 는 안 되고
        //안에 매개변수를 넣어줘야만 하는 상황이 발생한 것!!!
        public Product(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
