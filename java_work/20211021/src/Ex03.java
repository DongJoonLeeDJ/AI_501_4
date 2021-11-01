/* 문제2
 * 다음 식을 만족하는 모든 A B 를 구하자
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
 *  신입
 *  2600
 *  1년차..
 *  2800
 *  2년차..
 *  3000
 *  3년차..
 *  3200..
 *  
 *  컴퓨터공학과.. 정보처리기사.. 
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
