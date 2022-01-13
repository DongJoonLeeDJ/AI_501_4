package chap02;

public class MyMain {
	
	//싱글톤 패턴

	public static void main(String[] args) {
		
//		Greeter g1 = new Greeter();
//		Greeter g2 = new Greeter();
		
		Greeter g1 = Greeter.getInstance();
		Greeter g2 = Greeter.getInstance();
		
		System.out.println(g1);
		System.out.println(g2);
		
		System.out.println("(g1 == g2) = " + (g1 == g2));
		
	}
	
}
