import aa.BankAccount;

public class Ex08 {

	public static void main(String[] args) {
		BankAccount a1 = new BankAccount();
		a1.init("ㄱㅖ좌번호 1111 ", "주민 번호 1111", 1000);
		
		BankAccount a2 = new BankAccount();
		a2.init("ㄱㅖ좌번호 2222 ", "주민 번호 2222", 2000);
		
		a1.checkMybal();
		a2.checkMybal();
		
		// 초기화 메서드, 생성자, constructor
	}
}
