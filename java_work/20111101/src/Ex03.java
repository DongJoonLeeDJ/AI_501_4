import com.java.org.Rectangle;

public class Ex03 {

	public static void main(String[] args) {
		Rectangle r = new Rectangle(2, 2, 8, 7);
		r.setName("r");
		
		Rectangle s = new Rectangle(5, 5, 6, 6);
		s.setName("s");
		
		Rectangle t = new Rectangle(1, 1, 10, 10);
		t.setName("t");

		r.show();
		
		System.out.println("s의 면적은 " + s.square());
		
		if (t.contains(r))
			System.out.println("t는 r을 포함합니다.");
		
		if (t.contains(s))
			System.out.println("t는 s를 포함합니다.");
		else
			System.out.println("t는 s를 포함하지 않는다.");
	}

}
