import java.util.Scanner;

import aa.DD;

public class Ex09 {

	public static void main(String[] args) {
		// 숫자를 입력받아 해당되는 구구단을 출력
		System.out.println("숫자입력");
		Scanner scan = new Scanner(System.in);
		int num = scan.nextInt();
		
		DD d1 = new DD();
		d1.doA(num);
	}
}
