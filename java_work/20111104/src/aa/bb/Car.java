package aa.bb;

public class Car {
	public static int cnt = 0;// �ڵ����� ��������� ����
	private String name;
	private double dis;
	public Car() {
		cnt++;
	}
	public Car(String name, double dis) {
		cnt++;
		this.name = name;
		this.dis = dis;
	}
	public void setName(String name) {
		this.name = name;
	}
	public void setDis(double dis) {
		this.dis = dis;
	}
	public void doPrint() {
		System.out.println("name = "+ name);
		System.out.println("dis = "+ dis);
		System.out.println(cnt + "��°�� ��������ϴ�.");
	}
	// alt + shift + s -> o ������
	// alt + shift + s -> r setter ����Ű
	
	// 1. �����ڷ� �� ����
	// 2. setter ������� �� ����
	
}
