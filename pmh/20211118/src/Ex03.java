import java.util.InputMismatchException;
import java.util.Scanner;

public class Ex03 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        // 프로그램이 종료 되지 않도록 예외를 처리한다......
        // 3시간... 이따가..??
        // 알수없는 걸로... 종료된다..??
        try {
            System.out.println("a = ? ");
            int a = scanner.nextInt();
            System.out.println("b = ? ");
            int b = scanner.nextInt();

            System.out.println("a/b = ?" + a / b);
            System.out.println("완료...");
        }
        catch (Exception ae){
            ae.printStackTrace();
            System.out.println("모든 예외");
//            System.out.println("나누기 예외발생");
        }
//        catch (InputMismatchException ime){
//            ime.printStackTrace();
//            System.out.println("문자열 넣기 예외발생");
//        }

        System.out.println("bye bye");

    }

}
