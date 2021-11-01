package ccc;

// 패키지 명은 마음데로 지을수 있다...
// 클래스 명은 대문자로 시작해서 마음데로 지을 수 있다.

// 패키지가 선언되어 있지 않으면 src 폴더안에 ... 여러파일이 존재한다. 

public class Ex01 {
	public static void main(String args[]) {
		int MIN_SIZE = 200;
		final int MAX_SIZE = 100;

		System.out.println("MAX_SIZE = "+MAX_SIZE);
		System.out.println("MIN_SIZE = "+MIN_SIZE);
		MIN_SIZE = 300; // 변경가능
		System.out.println("MIN_SIZE = "+MIN_SIZE);
//		MAX_SIZE = 200;
				
	}
}


