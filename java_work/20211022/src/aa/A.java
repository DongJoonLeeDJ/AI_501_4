package aa;

public class A {

	public int a = 10;
	public int b = 20;
	
	// ����Լ�...
	public void fact(int num) {
		if ( num == 10) {
			System.out.println("ȣ��");
			return;
		}
		else {
			System.out.println("else");
			fact(num-1);
		}
	}
	
}
