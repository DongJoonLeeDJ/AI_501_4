/*
 * class명이랑 파일명은 동일해야 된다..
 * ctrl + 1
 */
public class Ex05 {
	
	public static void main(String[] args) {
		int num1 = 100;
		long num2 = 3147483647L;
		System.out.println(num1 + num2);
		
		int num3 = (int)(num1 + num2);
		long num4 = num1 + num2;
		System.out.println("num3 = "+num3);
		System.out.println("num4 = "+num4);
	}

}
