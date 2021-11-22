public class Ex03 {
    public static void main(String[] args) {
        Point p1 = new Point(3,5);
        Point p2 = p1;  // 참조변수 복사...
        Point p3 = null;

        try {
            p3 = (Point) p1.clone();
        } catch (CloneNotSupportedException e) {
            e.printStackTrace();
        }
        System.out.println("p1 시작");
        System.out.println(p1);
        p2.setXpos(10);
        System.out.println(p1);
        System.out.println("p3 시작");
        System.out.println(p3);
        p1.setXpos(20);
        System.out.println(p3);
    }
}
