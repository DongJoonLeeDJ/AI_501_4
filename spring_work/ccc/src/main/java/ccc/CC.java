package ccc;


public class CC {
	
	private AA aa;
	
	public CC(AA aa) {
		this.aa = aa;
		System.out.println("CC 생성 aa 의 주소값 = "+aa);
	}

	public void doCC() {
		System.out.println("CC doCC 호출...시작");
		aa.doA();
		System.out.println("CC doCC 호출...끝");
	}
}
