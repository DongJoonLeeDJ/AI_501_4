class Point {
	int xPos, yPos;
	public Point(int x, int y) {
		xPos = x;
		yPos = y;
	}
	public void showPointInfo() {
		System.out.println("[" + xPos + " , " + yPos + "]");
	}
}
class Circle {
	Point p1;
	int r;
	public Circle(int x, int y, int rad) {
		p1 = new Point(x, y);
		r = rad;
	}
	public void showPointInfo() {
		p1.showPointInfo();
		System.out.println("[" + r + "]");
	}
}
public class Ex03 {
	public static void main(String[] args) {
		Circle c = new Circle(2, 2, 4);
		c.showPointInfo();
	}
}
