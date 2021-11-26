import java.util.Random;

public class Ex06 {

    public static void main(String[] args) {
        System.out.println();
        Random ran1 = new Random(System.currentTimeMillis());
        for(int i = 0; i<7 ;i++)
            System.out.println(ran1.nextInt(1000));

//        Random ran2 = new Random(10);
//        for(int i = 0; i<7 ;i++)
//            System.out.println(ran2.nextInt(1000));
    }
}
