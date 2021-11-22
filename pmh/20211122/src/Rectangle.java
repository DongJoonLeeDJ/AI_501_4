public class Rectangle implements Cloneable{
    Point upperLeft;
    Point lowerRight;
    int x1 = 10;
    int y1 = 20;

    public Rectangle(int x1,int y1,int x2,int y2) {
        this.upperLeft = new Point(x1,y1);
        this.lowerRight = new Point(x2,y2);
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        Rectangle r1 = (Rectangle) super.clone();

        r1.upperLeft = (Point) upperLeft.clone();
        r1.lowerRight = (Point) lowerRight.clone();

        return r1;
    }
}
