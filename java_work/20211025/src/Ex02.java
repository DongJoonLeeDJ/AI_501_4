import java.util.Scanner;

import aa.Exam;

/*
 * ���ڷ� ������ ������ ���޹޾Ƽ� �̿� �ش��ϴ� ������ ǥ���� ����ϴ� ����
 *  10-> 1010
 *  8 -> 1000
 *  6 -> 0110
 *  4 -> 0100
 *  ���  
 */
public class Ex02 {

	public static void main(String[] args) {
		Exam ex = new Exam();
		Scanner scan = new Scanner(System.in);
		System.out.println("���� �Է�:");
		int inputIum = scan.nextInt();
		String result = ex.exam02(inputIum);
		System.out.println("result = "+result);
		
	}
}
