import java.util.Scanner;
import com.java.org.Grade;
/*
 *  Grade Ŭ������ �ۼ��غ���. 
 *  3 ������ ������ �Է¹޾� Grade ��ü�� �����ϰ� ���� 
 *  ����� ����ϴ� main()�� ���� ���ô� ������ ����.
 */
public class Ex01 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.print("����, ����, ���� ������ 3���� ���� �Է� >> ");
		int math = sc.nextInt();
		int science = sc.nextInt();
		int english = sc.nextInt();
		
		Grade me = new Grade(math, science, english);
		System.out.println("����� " + me.average()); 
		// average()�� ����� ����Ͽ� ����

		sc.close();
	}
}






