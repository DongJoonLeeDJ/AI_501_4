import java.util.Scanner;

/*
두 수를 입력받고 사칙 연산 출력 하시오
        예시
        1. 더하기 2. 빼기 3. 나누기 4 곱하기 5 나머지 6. 종료
        무엇을 하시겠습니까? >> 1
        첫번째 수 >>> 10
        두번째 수 >>> 20
        10+20 = 30
        1. 더하기 2. 빼기 3. 나누기 4 곱하기 5 나머지 6. 종료
        무엇을 하시겠습니까? >> 3
        첫번째 수 >>> 30
        두번째 수 >>> 20
        30/20 = 1
*/
public class Ex03 {
    public static void menu(){
        Scanner scan = new Scanner(System.in);
        while(true){
            System.out.println("1. 더하기 2. 빼기 3. 나누기 4 곱하기 5 나머지 6. 종료");
            int select = scan.nextInt();
            if (select == 1) {
                System.out.print("첫번째 수 입력 >> ");
                int firstNumber = scan.nextInt();   // fnumber = input("첫번째수 입력");
                System.out.print("두번째 수 입력 >> ");
                int secondNumber = scan.nextInt();
                System.out.println("더하기.. = "+(firstNumber+secondNumber));
            } else if (select == 2) {
                System.out.println("빼기..");
            } else if (select == 3) {
                System.out.println("나누기..");
            } else if (select == 4) {
                System.out.println("곱하기..");
            } else if (select == 5) {
                System.out.println("나머지..");
            } else if (select == 6) {
                System.out.println("종료합니다.");
                break;
            }
        }
    }

    public static void main(String[] args) {
        menu();
    }
}
