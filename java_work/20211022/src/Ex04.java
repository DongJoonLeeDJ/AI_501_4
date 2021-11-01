
// 3 * 2 * 1 = 6 
public class Ex04 {

	public static void main(String[] args) {
		System.out.println(fact(3));
		System.out.println(fact(4));
		System.out.println(fact(5));
	}
	
	/*
	 * fact(3)  
	 * -> 3 * fact(2)
	 * -> 3 * 2 * fact(1)
	 * -> 3 * 2 * 1
	 * -> 6....
	 */
	public static int fact(int num) {
		if(num==1)
			return num;
		else
			return num * fact(num-1);
	}
}
