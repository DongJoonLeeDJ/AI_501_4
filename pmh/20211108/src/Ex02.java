import java.util.Scanner;

/*
    2. "Hello.java" 문자열에서 파일명은 Hello와 확장자인 java를 분리시켜보자.
        입력 >> Hello.java
        출력
        파일명 Hello
        확장자 java
*/
public class Ex02 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("입력>> ");// input("입력");
        String inputString = scan.nextLine();
        System.out.println("inputString = "+inputString);
        String ar[] = inputString.split("\\.");
        System.out.println("출력");
        System.out.println("파일명 = "+ar[0]);
        System.out.println("확장자 = "+ar[1]);
    }
}
