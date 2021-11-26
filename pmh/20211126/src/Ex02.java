import java.util.Random;

public class Ex02 {

    public static void main(String[] args) {

        Random ran = new Random(System.currentTimeMillis());
        for (int i=0; i<7 ; i++) {
            System.out.println(ran.nextInt(1000));
        }

    }

}
