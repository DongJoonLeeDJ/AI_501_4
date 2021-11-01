import aa.BankAccount;

public class Ex06 {

	public static void main(String[] args) {
		int c = 10;
		
		BankAccount a = new BankAccount();
		BankAccount b = new BankAccount();
		
		a.deposit(1000);
		b.deposit(2000);
		
		a.checkMybal();
		b.checkMybal();
	}
	
}
