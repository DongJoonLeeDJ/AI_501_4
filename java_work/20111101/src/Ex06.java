class BBB{
	public static void doA() {
		System.out.println("doA");
	}
	public void doB() {
		System.out.println("doB");
	}
}
public class Ex06 {
	public static void main(String[] args) {
		
		BBB.doA();
//		BBB.doB();
		
		// ctrl + shift + c 주석 설정 및 해제
		BBB b1 = new BBB();
		b1.doB();
	}
}
