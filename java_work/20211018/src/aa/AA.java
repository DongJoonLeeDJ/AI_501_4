package aa;

public class AA {
	public void doA() {
		System.out.println("doA�Լ��Դϴ�.");
	}

	public void doB(int p1) {
		if (p1 < 0) {
			System.out.println(p1 + " �� 0���� �۽��ϴ�.");
		} else if (p1 < 100) {
			System.out.println(p1 + " �� 100���� �۽��ϴ�.");
		} else {
			System.out.println(p1 + "�� 100�̻�"); 
		}
	}
	public void doC(int num1, int num2) {
		int result = num1>num2? num1-num2: num2-num1;
		System.out.println("result = "+result);
	}
}
