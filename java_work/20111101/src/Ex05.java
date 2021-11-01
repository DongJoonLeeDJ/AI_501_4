class AAA{
	public static int AAAA = 1000;
}

public class Ex05 {
	public static int num = 100;
	
	public static String a = "aaaa";

	public static void main(String[] args) {
		Ex05.num -= 15;
		System.out.println("Ex05.num = "+Ex05.num);
		
		System.out.println("Ex05.a = "+Ex05.a);
		System.out.println("AAA.AAAA = "+AAA.AAAA);
	}
}
