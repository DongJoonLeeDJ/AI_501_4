import java.util.Scanner;
import aa.AA;

public class Ex01 {
	public static void main(String[] args) {
		int a = 10;
		String b = "bb";
		AA a1 = new AA();
		a1.doA();
		
		Scanner scan = new Scanner(System.in);
		System.out.println("���� �Է�");
		int n = scan.nextInt();
		
		if (n >= 0 && n < 10)
			System.out.println("0�̻� 10�̸��� ��");
		else if (n >= 10 && n < 20)
			System.out.println("10�̻� 20�̸��� ��");
		else if( n >=20 && n<30)
			System.out.println("20�̻� 30�̸��� ��");
		else
			System.out.println("���� Ȥ�� 30�̻��Ǽ�");
		
		switch (n/10) {
		case 0:
			System.out.println("0�̻� 10�̸��� ��");
			break;
		case 1:
			System.out.println("10�̻� 20�̸��� ��");
			break;
		case 2:
			System.out.println("20�̻� 30�̸��� ��");
			break;
		default:
			System.out.println("���� Ȥ�� 30�̻��Ǽ�");
			break;
		}
	}
}
