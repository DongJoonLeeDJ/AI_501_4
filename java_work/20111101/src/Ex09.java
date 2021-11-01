import java.lang.System;

// java -> jsp -> spring

class C{
	public void doA(String a) {
		System.out.println("static method doA"+a);
	}
}

class Cs{
	public static C cout = new C();
}

public class Ex09 {
	public static void main(String[] args) {
		Cs.cout.doA("aaaa");
		System.out.println("비슷하게....");
	}
}
