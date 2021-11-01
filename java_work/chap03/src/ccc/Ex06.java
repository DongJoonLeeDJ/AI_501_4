package ccc;

public class Ex06 {

	public static void main(String[] args) {
		
		int num1 = 11;
		int num2 = 22;
		boolean result;
		
		result = num1 < num2;
		System.out.println("result ="+result);
		
		result = num1 < num2 && (num1 > 100 || num1 == 11) && num2 == 22;
		System.out.println("result ="+result);
		
		result = num1 < num2 || num1 > 100;
		System.out.println("result ="+result);
		
		
	}
}
