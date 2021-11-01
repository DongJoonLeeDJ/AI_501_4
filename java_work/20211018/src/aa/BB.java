package aa;

public class BB {

	public void doA() {
		int n = 3; // 지역변수..
		switch (n) {
		case 1:
			System.out.println("111111111");
		case 2:
			System.out.println("222222222");
		case 3:
			System.out.println("333333333");
		case 4:
			System.out.println("444444444");
			break;
		default:
			System.out.println("default...");
		}
	}

	public void doB() {
		int num1 = 0;
		while (num1 < 5) {
			System.out.println("num1 = " + num1);
			num1 += 1;
//			num1++;
		}
	}

	public void doC(int num1) {
		System.out.println("doC시작");
		for (; num1 < 5; num1++) {
			System.out.println("num1 = "+num1);
		}
	}
}
