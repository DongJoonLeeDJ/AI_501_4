
public class Ex02 {

	public static void doA(int a) {
		System.out.println(" a = "+a);
	}
	
	public static void main(String[] args) {
		A a = new A();
		
		ABC abc = new ABC();
		abc.takeB(new B());
		abc.takeC(new C());
		abc.takeA(a);
		
		abc.seqtakeABC(new A(), new B(), new C());
	}
}
