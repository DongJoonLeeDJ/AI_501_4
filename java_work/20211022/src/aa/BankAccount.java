package aa;

public class BankAccount {
	public int bal = 0;
	public String accNumber;
	public String ssNumber;
	
	public BankAccount() { }
	
	// 생성자 함수... constructor.... 초기화 메서드......
	public BankAccount(String acc, String ss, int b) {
		accNumber = acc;
		ssNumber = ss;
		bal = b;
	}

	public void deposit(int num) {
		bal += num;
	}

	// ctrl + shift + f 자동정렬
	public void checkMybal() {
		System.out.println("계좌번호 : "+ accNumber);
		System.out.println("주민번호 : "+ ssNumber);
		System.out.println("금액 : " + bal);
	}

	public void init(String acc, String ss, int b) {
		accNumber = acc;
		ssNumber = ss;
		bal = b;
	}
}