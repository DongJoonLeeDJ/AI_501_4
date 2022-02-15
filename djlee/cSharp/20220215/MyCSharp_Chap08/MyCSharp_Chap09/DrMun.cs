using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap09
{
    public class DrMun : LOL, IqwerKey, ISkinColor, IMonsterFight
    {
        public void Attack()
        {
            System.Windows.Forms.MessageBox.Show("칼등찍기");
        }

        //public string Key { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void BornVoice()
        {
            System.Windows.Forms.MessageBox.Show("문도오오오");
        }

        public override void DieVoice()
        {
            System.Windows.Forms.MessageBox.Show("ㅈㅅ");
        }

        public void eKey()
        {
            System.Windows.Forms.MessageBox.Show("문도 칼을 던진다.");
        }

        public void MagicArrow()
        {
            System.Windows.Forms.MessageBox.Show("얜 마법이 없어여 ");
        }

        public void PhysicalAttack()
        {
            System.Windows.Forms.MessageBox.Show("붙잡고 때리기");
        }

        public void qKey()
        {
            System.Windows.Forms.MessageBox.Show("문도 칼을 찌른다.");
        }

        public void rKey()
        {
            System.Windows.Forms.MessageBox.Show("문도오오오오오! " + name + "의 궁극기 시전! " + race+"의 비장의 무기");

        }

        public void showColor()
        {
            System.Windows.Forms.MessageBox.Show("보라색");
        }

        public void wKey()
        {
            System.Windows.Forms.MessageBox.Show("문도 내 주변 애들 빨라지게 해라");
        }
    }
}
