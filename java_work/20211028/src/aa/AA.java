package aa;

public class AA {
	public int num1;
	public int num2;
	public int num3;
	public String name;
	
	public AA(){}
	public AA(int n) {
		num1 = n;
	}
	public AA(int n, String sn) {
		num1 = n;
		name = sn;
	}
	
	public void doPrint() {
		System.out.println("name = "+name);
		System.out.println("num1 = "+num1);
	}

}
