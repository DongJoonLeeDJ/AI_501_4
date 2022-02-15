using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Chap09
{
    public class Cogmo : LOL, IqwerKey, ISkinColor, IMonsterFight
    {
        public override void BornVoice()
        {
            System.Windows.Forms.MessageBox.Show("쿠웨웨엑");
            //throw new NotImplementedException();
        }

        public override void DieVoice()
        {
            System.Windows.Forms.MessageBox.Show("ㅠㅠ");
            //throw new NotImplementedException();
        }

        public void qKey()
        {
            System.Windows.Forms.MessageBox.Show("독침공격!");
        }
        public void wKey()
        {
            System.Windows.Forms.MessageBox.Show("짖기!");
        }
        public void eKey()
        {
            System.Windows.Forms.MessageBox.Show("물기!");
        }

        public void rKey()
        {
            System.Windows.Forms.MessageBox.Show(name+"님이 궁극기 시전! 슈퍼파워그레잇!"+race+"족의 영광을 위하여!");
        }

        public void showColor()
        {
            System.Windows.Forms.MessageBox.Show("코그모 색깔");
        }

        public void MagicArrow()
        {
            //throw new NotImplementedException();
            System.Windows.Forms.MessageBox.Show("포이즌 애로우");
        }

        public void PhysicalAttack()
        {
            //throw new NotImplementedException();
            System.Windows.Forms.MessageBox.Show("이빨치기");
        }

        public void Attack() //IFight에 있던 메소드
        {
            System.Windows.Forms.MessageBox.Show("가벼운 독침공격");
        }
    }
}
