class Boat{
	public void myboat() {
		System.out.println("�̰��� ��Ʈ");
	}
}
// stack... ����.... �޸𸮿���.. LIFO
// �޸𸮰����� �÷� ���� ����� �ؾߵȴ�...
// 1. static .. ���α׷��� ���������� ����
// 2. ��ü ����(�ν��Ͻ�ȭ,�޸𸮿��Ҵ�) -> non static -> jvm �˾Ƽ� ����..
public class Car {
	public void myCar() {
		System.out.println("�̰��� �� �ڵ���");
	}
	public static void main(String[] args) {
		Car c1 = new Car();
//		String a[] = {"22","11"};
//		c1.main(a);
		c1.myCar();
		Boat boat = new Boat();
		boat.myboat();
	}
}