import java.util.Scanner;

import aa.Exam;

// ���� 1 ���� n�� ���޾Ƽ� 2�� n���� ����Ͽ� ��ȯ�ϴ� ��� �޼���
// 010 - 9946 - 2662 �ڸ�ȸ
public class Ex01 {
	
	public static void main(String[] args) {
		Exam ex = new Exam();
		Scanner scan = new Scanner(System.in);
		while(true) {
			System.out.println("����� ���Ͻʴϱ�?");
			int inputNum = scan.nextInt();
			int result = ex.exam01(inputNum);
			if(inputNum == -1) {
				System.out.println("�����մϴ�.");
				break;
			}
			else {
				System.out.println("result = "+result);
			}
		}
		
	}

}
