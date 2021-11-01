/*
 * ctrl + s 저장
 * 
 * ㅁㄴㅇㄻㄴㅇㄹ
 * 이클립스에서는 저장 하는 순간 컴파일을 합니다.
 * A.java -> A.class
 */
public class D {

	public static void main(String[] args) {
		int a = 10;
		double b = 20;
		b = a;
		System.out.println("b = "+ b);
		a = (int)b;
		System.out.println("a = "+ a);
	}
}
