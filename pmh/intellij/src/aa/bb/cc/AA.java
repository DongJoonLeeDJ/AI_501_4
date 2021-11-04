package aa.bb.cc;
// 오버로딩
public class AA {
    public void doA(){
        System.out.println("기본 doA 메서드");
    }
    public void doA(int a){
        System.out.println("int a 있는 doA 메서드");
    }
    public void doA(double a){
        System.out.println("double a 있는 doA 메서드");
    }
}
