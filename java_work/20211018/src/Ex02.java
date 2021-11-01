/*
 * 문제4
 * 문제5
 */
public class Ex02 {

	public static void main(String[] args) {
		// 3+6 3+6+9 3+6+9+12
		int a = 3 + 6;
		int b = 3 + 6 + 9;
		int c = 3 + 6 + 9 + 12;

		System.out.println("a = " + a);
		System.out.println("b = " + b);
		System.out.println("c = " + c);
		// n1> n2 >n3
		double n1 = ((25 + 5) + (36 / 4) - 72 * 5);
		double n2 = ((25 * 5) + (36 - 4) + 71) / 4;
		double n3 = (128 / 4) * 2;
		System.out.println("n1 = "+n1);
		System.out.println("n2 = "+n2);
		System.out.println("n3 = "+n3);
		System.out.println(n1 > n2 && n2 > n3);

	}

}
