class UCls {}
class DCls extends UCls {}
public class Ex02 {
    public static void main(String[] args) {
        UCls uCls = new UCls();
        DCls dCls = (DCls) uCls;

        System.out.println("진행");
        
        DCls dCls1 = new DCls();
        UCls ucls1 = (UCls) dCls1;

        System.out.println("완료");
    }
}
