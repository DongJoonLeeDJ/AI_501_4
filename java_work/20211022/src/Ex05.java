
public class Ex05 {
	public static int bal = 0;
	
	public static void main(String[] args) {
		deposit(10000);
		checkMyBal();
		withdraw(3000);
		checkMyBal();
		System.out.println("bal ="+bal);
	}
	
	public static int deposit(int num) {
		bal += num;
		return bal;
	}
	public static int withdraw(int num) {	
		bal -= num;
		return bal;
	}
	public static int checkMyBal() {
		System.out.println("ภÜพื : "+bal);
		return bal;
	}
	
	
}
