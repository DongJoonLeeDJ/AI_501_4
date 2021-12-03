
interface MyInter{
    void doA();
}
class A implements MyInter{
    @Override
    public void doA(){}
}
/*
    원래는 Interface 거를... 생성자로 통해서 생성할려면
    class 상속 받아서 @override 를 해서.. 객체 생성을해야하는데..
    익명 클래스를 쓰면..

 */
public class Ex02 {
    public static void main(String[] args) {
        A a = new A();
        MyInter m1 = new MyInter(){
            @Override
            public void doA(){
                System.out.println("m1");
            }
        };
        m1.doA();

        MyInter m2 = new MyInter(){
            @Override
            public void doA(){
                System.out.println("m2");
            }
        };

        m2.doA();


    }
}
