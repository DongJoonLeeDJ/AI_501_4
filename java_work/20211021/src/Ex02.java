/*
 * ����1
 * �������� ¦�� ��� 2,4,6,8�ܸ� ����ϴ� ���α׷��� �ۼ��ϵ�
 * 2*2����, 4���� 4*4���� 6���� 6*6���� 8���� 8*8����
 * ����2
 * ���� ���� �����ϴ� ��� A B �� ������
 *  AB
 * +BA
 *  99
 *  A + B = 9
 */
public class Ex02 {
	public static void main(String[] args) {
		for(int dan = 2; dan < 9; dan+=2) {
			for( int i=1; i<dan+1; i++) {
//				System.out.println("dan = "+dan);
//				System.out.println("i = "+i);
				System.out.print(dan+"*"+i+"="+dan*i+"\t");
			}
			System.out.println();
		}
	}
}
