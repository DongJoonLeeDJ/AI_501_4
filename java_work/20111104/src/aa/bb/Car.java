package aa.bb;

public class Car {
	public static int cnt = 0;// 자동차가 만들어질때 마다
	private String name;
	private double dis;
	public Car() {
		cnt++;
	}
	public Car(String name, double dis) {
		cnt++;
		this.name = name;
		this.dis = dis;
	}
	public void setName(String name) {
		this.name = name;
	}
	public void setDis(double dis) {
		this.dis = dis;
	}
	public void doPrint() {
		System.out.println("name = "+ name);
		System.out.println("dis = "+ dis);
		System.out.println(cnt + "번째로 만들었습니다.");
	}
	// alt + shift + s -> o 생성자
	// alt + shift + s -> r setter 단축키
	
	// 1. 생성자로 값 설정
	// 2. setter 방식으로 값 설정
	
}
