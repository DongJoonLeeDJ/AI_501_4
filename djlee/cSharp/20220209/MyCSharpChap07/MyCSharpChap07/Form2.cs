using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharpChap07
{
    public partial class Form2 : Form
    {
        List<Dog> dogs = new List<Dog>();
        List<Cat> cats = new List<Cat>();
        List<Animal> animals = new List<Animal>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            dogs.Add(d);
           //  dogs.Add(new Dog());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            cats.Add(c);
            //cats.Add(new Cat());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animal a = new Dog(); //다형성!!!
            a.Sleep();
            ((Dog)a).Bark();
            animals.Add(a);

           // animals.Add(new Dog());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal a = new Cat();
            a.Sleep();
           // ((Dog)a).Bark();//??????
            ((Cat)a).Meow();
            animals.Add(a);
           // animals.Add(new Cat());
        }

        //동물별 합주
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in dogs)
            {
                item.Sleep();
                item.Eat();
                item.Bark();
            }

            foreach (var item in cats)
            {
                item.Sleep();
                item.Eat();
                item.Meow();
            }

        }
        //Animals 리스트 하나만 쓰면 됨
        private void button6_Click(object sender, EventArgs e)
        {
            foreach(var item in animals)
            {
                item.Sleep();
                item.Eat();
                if (item is Dog) //만약에 item이 Dog 타입으로 형변환이 된다면...
                    (item as Dog).Bark(); //item을 Dog로 형변환함
                                          // if (item is Cat)//만약에 item이 Cat 타입으로 형변환이 된다면...
                                          //     (item as Cat).Meow(); //item을 cat으로 형변환함

                var cat = item as Cat; //Cat으로 형변환하되, 형변환 실패하면 null값임.
                if (cat != null)
                    cat.Meow();

            }
        }
    }
}
