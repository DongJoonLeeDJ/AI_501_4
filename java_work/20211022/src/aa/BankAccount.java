package aa;

public class BankAccount {
	public int bal = 0;
	public String accNumber;
	public String ssNumber;
	
	public BankAccount() { }
	
	// ������ �Լ�... constructor.... �ʱ�ȭ �޼���......
	public BankAccount(String acc, String ss, int b) {
		accNumber = acc;
		ssNumber = ss;
		bal = b;
	}

	public void deposit(int num) {
		bal += num;
	}

	// ctrl + shift + f �ڵ�����
	public void checkMybal() {
		System.out.println("���¹�ȣ : "+ accNumber);
		System.out.println("�ֹι�ȣ : "+ ssNumber);
		System.out.println("�ݾ� : " + bal);
	}

	public void init(String acc, String ss, int b) {
		accNumber = acc;
		ssNumber = ss;
		bal = b;
	}
}