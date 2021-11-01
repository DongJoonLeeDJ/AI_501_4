import aa.BankAccount;

public class Ex09 {

	public static void main(String[] args) {
		
		BankAccount a1 = new BankAccount("계좌번호 1111","주민번호 1111",10000);
		BankAccount a2 = new BankAccount("계좌번호 2222","주민번호 2222",20000);
		
		a1.checkMybal();
		a2.checkMybal();
		
		
	}
}
