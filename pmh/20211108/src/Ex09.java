class MyBox{
    private String name;
    private int boxnum;
    public int getBoxnum() {
        return boxnum;
    }
    public MyBox(String name,int boxnum) {
        this.name = name;
        this.boxnum = boxnum;
    }
    @Override
    public String toString() {
        return "MyBox{" +
                "Name='" + name + '\n' +
                ", boxnum=" + boxnum +
                '}';
    }
}
public class Ex09 {
    public static void main(String[] args) {
        MyBox[] mybox = new MyBox[3];

        mybox[0] = new MyBox("coffee",101);
        mybox[1] = new MyBox("Computer",202);
        mybox[2] = new MyBox("Dress",303);

        for(MyBox mB : mybox){
            if(mB.getBoxnum() == 303)
                System.out.println(mB.toString());
        }

    }
}
