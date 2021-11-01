package aa;

public class A {

	public int a = 10;
	public int b = 20;
	
	// 재귀함수...
	public void fact(int num) {
		if ( num == 10) {
			System.out.println("호출");
			return;
		}
		else {
			System.out.println("else");
			fact(num-1);
		}
	}
	
}
