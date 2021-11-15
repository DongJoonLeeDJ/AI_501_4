// 부모클래스
class PA{
}
// 자식클래스 C1
class C1 extends PA{
    @Override
    public String toString(){
        return "C1";
    }
}
// 자식클래스 C2
class C2 extends PA{
    public String toString(){
        return "C2";
    }
}
public class Ex01 {
    public static void main(String[] args) {
        PA p1 = new C1();
        PA p2 = new C2();
        System.out.println(p1);
        System.out.println(p2);
    }
}
