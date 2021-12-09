

interface AA{
    void cal(int a,int b);
//    void doAA();
}

public class Ex02 {
    public static void main(String[] args) {
        AA obja = new AA() {
            @Override
            public void cal(int a, int b) {
                System.out.println(a+b);
            }
//            @Override
//            public void doAA() {
//            }
        };
        obja.cal(10,20);

        AA lama = (a,b)-> System.out.println(a+b);
        lama.cal(10,20);


    }
}
