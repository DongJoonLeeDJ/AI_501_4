public class Ex04 {
    public static void main(String[] args) {
        Rectangle r1 = new Rectangle(1,1,9,9);
        Rectangle r2 = null;
        try {
            r2 = (Rectangle) r1.clone();
        } catch (CloneNotSupportedException e) {
            e.printStackTrace();
        }
        System.out.println("r1 출력시작");
        System.out.println("r1.lowerRight"+r1.lowerRight);
        System.out.println("r1.upperLeft"+r1.upperLeft);
        r2.lowerRight.setXpos(30);
        System.out.println("r1.lowerRight"+r1.lowerRight);
        System.out.println("r1.upperLeft"+r1.upperLeft);

        System.out.println("r2 출력시작");
        System.out.println("r2.lowerRight"+r2.lowerRight);
        System.out.println("r2.upperLeft"+r2.upperLeft);
    }
}
