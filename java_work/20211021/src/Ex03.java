/* ����2
 * ���� ���� �����ϴ� ��� A B �� ������
 *  AB
 * +BA
 *  99
 *  A + B = 9
 *  A = 1 B = 1~8
 *  A = 2 B = 1~8
 *  A = 3 B = 1~8
 *  ...
 *  A = 8 B = 1~8
 *  
 *  27 -> 30,31
 *  
 *  ����
 *  2600
 *  1����..
 *  2800
 *  2����..
 *  3000
 *  3����..
 *  3200..
 *  
 *  ��ǻ�Ͱ��а�.. ����ó�����.. 
 *  3000, 3200, 3400, 3600
 */
public class Ex03 {
	public static void main(String[] args) {
		int A = 0;
		// A=A+1 ,A+=1, A++
		for (; A < 10; A = A + 1) {
//			System.out.println("A = " + A);
			for (int B = 0; B < 10; B = B + 1) {
//				System.out.println("B = " + B);
				if ((A + B) == 9)
					System.out.println("A = " + A + " B=" + B);
			}
		}
	}
}
