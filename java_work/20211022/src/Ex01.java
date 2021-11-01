/*
 * 1. 정수 둘을 인자로 전달 받아서 두수의 사칙연산 결과를 출력하는 메소드와
 *   이 메소드를 호출하는 main 메서도를 정의해보자.
 *   단 나눗셈은 몫과 나머지를 각각 출력해야 한다.
 */
class A{
	public void doCalc(int a,int b) {
		System.out.println("덧셈 = "+(a+b));
		System.out.println("빼기 = "+(a-b));
		System.out.println("곱하기 = "+(a*b));
		System.out.println("몫 = "+(a/b)+" 나머지 = "+(a%b));
	}
}

public class Ex01 {
	public static void main(String[] args) {
		A a = new A();
		a.doCalc(3,4);
		
	}
}
