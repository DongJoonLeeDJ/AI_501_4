import aa.BankAccount;

public class Ex07 {

	public static void main(String[] args) {
	
		BankAccount ref1 = new BankAccount();
		BankAccount ref2 = ref1;
		
		ref1.deposit(1000);
		ref2.checkMybal();
		
		ref2.deposit(2000);
		ref1.checkMybal();
		
		check(ref1);
		System.out.println("acc���� �ٲ�");
		ref1.checkMybal();
		ref2.checkMybal();
		
		ref1 = null;
		if( ref1 == null) {
			System.out.println("���� ��Ŵ");
		}
		if (ref2 != null) {
			System.out.println("ref2�� ������..");
		}
		
	}
	public static void check(BankAccount acc) {
		acc.bal=5000;
	}
	
}











