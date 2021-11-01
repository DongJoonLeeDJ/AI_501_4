import com.java.org.AA;
import com.java.org.BB;

public class Ex04 {

	public static void main(String[] args) {
	AA a1 = new AA();
	System.out.println("a1.a = "+a1.a);
	System.out.println("a1.AMAX = "+a1.AMAX);
	a1.addE();
	System.out.println("a1.a = "+a1.a);
	System.out.println("a1.AMAX = "+AA.AMAX);
	
	AA a2 = new AA();
	System.out.println("a2.a = "+a2.a);
	System.out.println("a2.AMAX = "+AA.AMAX);
	a2.addE();
	System.out.println("a2.a = "+a2.a);
	System.out.println("a2.AMAX = "+AA.AMAX);
	
	a1.useBMAX();
	a2.useBMAX();
	System.out.println("BB.BMAX = "+BB.BMAX);
	}
	
}














