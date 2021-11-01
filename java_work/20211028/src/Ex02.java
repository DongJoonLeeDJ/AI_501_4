import aa.AA;

// oop
// 객체 지향 프로그래밍
public class Ex02 {

	public static void main(String[] args) {
		int num1ary[] = new int[3];
		int num2ary[] = new int[3];
		int num3ary[] = new int[3];
		String nameary[] = new String[3];
		
		AA aarray[] = new AA[3];
		for (int i = 0; i<3; i++) {
			aarray[i] = new AA((i+1)*10,"a"+i);
		}
		
		for (int i = 0; i<3; i++) {
//			System.out.println("aarray["+i+"] = "+aarray[i]);
			aarray[i].doPrint();
			System.out.println();
		}
		
	}
}
