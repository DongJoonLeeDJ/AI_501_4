package aa;

public class AA {
	public void doA() {
		System.out.println("doA함수입니다.");
	}

	public void doB(int p1) {
		if (p1 < 0) {
			System.out.println(p1 + " 는 0보다 작습니다.");
		} else if (p1 < 100) {
			System.out.println(p1 + " 는 100보다 작습니다.");
		} else {
			System.out.println(p1 + "는 100이상"); 
		}
	}
	public void doC(int num1, int num2) {
		int result = num1>num2? num1-num2: num2-num1;
		System.out.println("result = "+result);
	}
}
