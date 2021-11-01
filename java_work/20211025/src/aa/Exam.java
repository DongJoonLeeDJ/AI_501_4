package aa;

public class Exam {

	public int exam01(int n) {
		if( n > 0)
			return 2* exam01(n-1);
		else
			return 1;
	}
	
	// 10 -> 0 + exam02(5)
	// 0 + 1 + exam02(2)
	// 0 + 1 + 0 + exam02(1)
	// 0 + 1 + 0 + 1 + exam02(0) 
	public String exam02(int n) {
		if (n > 0) {
			return exam02(n/2)+n%2;
		}
		else {
			return "";
		}
	}
	
}
