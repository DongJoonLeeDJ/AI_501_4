using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cogmo c;
        DrMun d;
        private void button1_Click(object sender, EventArgs e)
        {
            c = new Cogmo();
            c.name = "커그머";
            c.race = "괴물";
            c.BornVoice();
            c.DieVoice();

            d = new DrMun();
            d.name = "분도박사";
            d.race = "프랑켄슈타인";
            d.BornVoice();
            d.DieVoice();

            MessageBox.Show("c의 이름은 "+c.name+" 종족은 "+c.race);
            MessageBox.Show("d이름은 "+d.name+" 종족은 "+d.race);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.qKey();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.wKey();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.eKey();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.rKey();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            d.qKey();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            d.wKey();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            d.eKey();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            d.rKey();
        }


        //IMonsterFight라는 인터페이스를 구현한 모든 인스턴스들이 매개변수가 된다.
        //Cogmo, DrMun, BabyMundo 모두 IMonsterFight를 구현한 클래스들이므로
        //이 메소드의 매개변수로 들어올 수 있게 됨.
        void ChampionAttack(IMonsterFight m)
        {
            m.Attack();
            m.PhysicalAttack();
            m.MagicArrow();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChampionAttack(c); //코그모
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChampionAttack(d); //문도
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BabyMundo b = new BabyMundo();
            ChampionAttack(b);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //인터페이스를 이용한 다형성 활용
            IMonsterFight ac = new Cogmo();
            IMonsterFight am = new DrMun();
            IMonsterFight ab = new BabyMundo();

            ac.MagicArrow();
            am.MagicArrow();
            ab.MagicArrow();


            IList myList = new ArrayList();
            List<IMonsterFight> my2 = new List<IMonsterFight>();

            //이 리스트들에는 IMonsterFight가 구현된 객체만 들어갈 수 있다.

        }
    }
}
