
class AA{
    public void doA(){}
}

class AAA extends AA{
    @Override
    public void doA(){
        System.out.println("재정의된 메서드");
    }
    public void doB(){
        System.out.println("재정의..???");
    }
}

public class Ex04 {
    public static void main(String[] args) {
        AA aa = new AAA();
        aa.doA();
//        aa.doB();
    }
}
