public class Point implements Cloneable{
    private int xpos;
    private int ypos;

    public void setXpos(int xpos) {
        this.xpos = xpos;
    }

    public Point(int xpos, int ypos) {
        this.xpos = xpos;
        this.ypos = ypos;
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone();
    }

    @Override
    public String toString() {
        return "Point{" +
                "xpos=" + xpos +
                ", ypos=" + ypos +
                '}';
    }
}
