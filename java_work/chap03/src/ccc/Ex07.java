package ccc;

public class Ex07 {

	public static void main(String[] args) {
		int num1 = 10;
		int num2 = 20;
		boolean result;
		result = num1 >100 && (num2 += 10) <100;
		
		System.out.println("result = "+result);
		System.out.println("num1 = "+ num1);
		System.out.println("num2 = "+ num2);		
		
		result = num1 >100 || (num2 += 10) <100;
		
		System.out.println("result = "+result);
		System.out.println("num1 = "+ num1);
		System.out.println("num2 = "+ num2);
		
	}
}

