class A{
	static int num = 0;
	static void addNum(int n) {
		num += n;
	}
}
public class Ex08 {

	public static void main(String[] args) {
		A.addNum(100);
		
		
		A a = new A();
		a.addNum(10);
	}
	
}
