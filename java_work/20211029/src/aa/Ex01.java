package aa;
/*
 * ?????? ?޼???
 * public protected default private
 * 
 * class public default
 */

public class Ex01 {

	public static void main(String[] args) {
		Member m1 = new Member();
//		m1.name = "asdf";
		m1.setName("ȫ?浿");
		m1.setAge(10);
		m1.print();
		
		Member m2 = new Member();
		m2.setName("???浿");
		m2.setAge(20);
		m2.print();
		
		Member m3 = new Member();
		m3.setName("?̱浿");
		m3.setAge(30);
		m3.print();
	}
	
}
