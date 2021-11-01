package aa;

public class Triangle {
	int base;	// 밑변
	int height;	// 높이

//	public Triangle() {} 생략되어져 있다. jvm 삽입해준다..
	
	// 인자값이 있는 생성자 선언시 기본생성자는 생략 불가.
	public Triangle(int b,int h) {
		base = b;
		height = h;
	}
	
	public double traArea() {
		return (double)base * height / 2;
	}
}
