/*
 * ���� ���� ���ڷ� ���� �޾Ƽ�, �� ���� '���� ���밪'�� ����Ͽ� ����ϴ� �޼ҵ��
 *  �� �޼Ҹ� ȣ���ϴ� main�޼ҵ带 �����غ���.
 *  
 *  �� �޼ҵ� ȣ�� �� ���޵Ǵ� ���� ������ ������� ���� ���� ���ǰ� ��µǾ���Ѵ�..
 */
class B{
	public void doABS(int a, int b) {
		System.out.println(a);
		System.out.println(b);
		if (a > b) {
			System.out.println("���� ���밪 = "+(a-b));
		}else {
			System.out.println("���� ���밪 = "+(b-a));
		}
	}
}
public class Ex02 {
	public static void main(String[] args) {
		B b = new B();
		b.doABS(5, 4);
	}
}

