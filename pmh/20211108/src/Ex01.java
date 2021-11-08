import java.util.Scanner;

/*
    1. 문자열 변경과 분리하기(split or substring)사용하기
        EX)
        입력
        이름을 성과 이름을 띄워서 영어로 입력>> park myounghoi
        출력
        parkmyounghoi
        성 park
        이름 myounghoi
*/
public class Ex01 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("이름을 성과 이름을 띄워서 영어로 입력>> ");
        String inputString = scan.nextLine();
        System.out.println("inputString = "+inputString);
        String ar[] = inputString.split(" ");
//        for ( int i =0; i< 10; i++) System.out.println(i);
//        for(String a : ar){
        System.out.println("성 = "+ar[0]);
        System.out.println("이름 = "+ar[1]);
//        }
//        int blinkNumber = inputString.charAt(3);
//        System.out.println("blinkNumber = "+ blinkNumber);

    }
}
