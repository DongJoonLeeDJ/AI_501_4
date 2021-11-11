class A {
    int pa = 10;
    public void pdoA() {
        System.out.println("pa = " + pa);
    }
}
class AA extends A{
    public void cdoAA(){
        System.out.println("AA cdoAA");
    }
}
class AB extends A{
    public void cdoAB(){
        System.out.println("AB cdoAB");
    }
}
public class EX01 {
    public static void main(String[] args) {
        AA aa = new AA();
        aa.pdoA();
        aa.cdoAA();

        AB ab = new AB();
        ab.pdoA();
        ab.cdoAB();
    }
}
