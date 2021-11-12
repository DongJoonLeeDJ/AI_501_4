public class AA extends A{
    int b = 20;
    @Override   // 생략 가능 재정의..
    public void doA(){
        super.doA();
        System.out.println("AA doA");
    }
}
