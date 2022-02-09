using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpChap07_02
{

    public class Animal : Creature
    {
        public string number { get; set; } //동물고유번호... 근데 여기선 문자열이지만... Dog는 숫자로만 분류할수도있을것이다.
        public void Sleep() //개는 잠을 개처럼 잘 것이다.
        {
            System.Windows.Forms.MessageBox.Show("쿨쿨 잠을 잡니다.");
        }

        //오버라이딩할 것은 부모클래스의 메소드에는 virtual 붙이고, 자식 클래스의 메소드에는 override 붙임
        public virtual void Eat() //개는 개처럼 먹을 것이다.
        {
            System.Windows.Forms.MessageBox.Show("밥을 먹습니다.");
        }

        public override void Born()
        {
            System.Windows.Forms.MessageBox.Show("응애응애");
            //throw new NotImplementedException();
        }

        public override void Die()
        {
            System.Windows.Forms.MessageBox.Show("...");
            //throw new NotImplementedException();
        }
    }
}
