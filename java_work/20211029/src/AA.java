class PAA{
	int num;
}

public class AA extends PAA{
	public AA() {
		System.out.println("num = "+ num);
		System.out.println("일로온다.");
	}

	public static void main(String[] args) {
		new AA();
	}
}
