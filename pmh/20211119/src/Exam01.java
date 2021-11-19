import java.util.Scanner;

/*
4.
다수의 클래스를 만들고 활용하는 연습을 해보자.
더하기(+), 빼기(-),  곱하기(*), 나누기(/)를 수행하는 각 클래스 Add, Sub, Mul, Div를 만들어라.
이들은 모두 다음 필드와 메소드를 가진다.
- int 타입의 a, b 필드: 2개의 피연산자
- void setValue(itn a, int b): 피연사 값을 객체 내에 저장한다.
- int calculate(): 클래스의 목적에 맞는 연산을 실행하고 결과를 리턴한다.
main() 메소드에서는 다음 실행 사례와 같이 두 정수와 연산자를 입력받고
Add, Sub, Mul, Div 중에서 이 연산을 실행할 수 있는 객체를 생성하고
 setValue()와 calculate()를 호출하여 결과를 출력하도록 작성하라.
  (참고: 이 문제는 상속을 이용하여 다시 작성하도록 5장의 실습문제로 이어진다.)

두 정수와 연산자를 입력하시오 >> 5 7 *
35
 */
public class Exam01 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("두 정수와 연산자를 입력하시오 >>");
        String susic = scan.nextLine();
        String arry[] = susic.split("\\s");
        System.out.println(arry[0]);
        System.out.println(arry[1]);
        System.out.println(arry[2]);
        if (arry[2].equals("+")) {
            Calcu add = new Add();
            add.setValue(Integer.parseInt(arry[0]), Integer.parseInt(arry[1]));
            add.calculate();
        }
        else if (arry[2].equals("-")) {
            Calcu add = new Sub();
            add.setValue(Integer.parseInt(arry[0]), Integer.parseInt(arry[1]));
            add.calculate();
        }
        else if (arry[2].equals("*")) {
            Calcu add = new Mul();
            add.setValue(Integer.parseInt(arry[0]), Integer.parseInt(arry[1]));
            add.calculate();
        }
        else if (arry[2].equals("/")) {
            Calcu add = new Div();
            add.setValue(Integer.parseInt(arry[0]), Integer.parseInt(arry[1]));
            add.calculate();
        }
    }
}
