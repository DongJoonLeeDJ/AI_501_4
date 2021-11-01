/*
 * 정수 둘을 인자로 전달 받아서, 두 수의 '차의 절대값'을 계산하여 출력하는 메소드와
 *  이 메소를 호출하는 main메소드를 정의해보자.
 *  
 *  단 메소드 호출 시 전달되는 값의 순서에 상관없이 절대 값이 계산되고 출력되어야한다..
 */
class B{
	public void doABS(int a, int b) {
		System.out.println(a);
		System.out.println(b);
		if (a > b) {
			System.out.println("차의 절대값 = "+(a-b));
		}else {
			System.out.println("차의 절대값 = "+(b-a));
		}
	}
}
public class Ex02 {
	public static void main(String[] args) {
		B b = new B();
		b.doABS(5, 4);
	}
}

