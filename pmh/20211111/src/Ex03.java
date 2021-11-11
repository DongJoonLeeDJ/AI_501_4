class PPA{
    public static int count = 10;
}
class CPA extends PPA{
    public void doA(){
        System.out.println("count = "+count);
    }
}
public class Ex03 {
    public static void main(String[] args) {
        new CPA().doA();
        System.out.println("static으로 접근");
        System.out.println(PPA.count);
    }
}
