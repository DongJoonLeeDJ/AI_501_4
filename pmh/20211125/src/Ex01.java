import java.lang.*; // 생략가능...

class Box implements Cloneable{
    private String element;
    public Box(String element) {
        this.element = element;
    }

    public void setElement(String element) {
        this.element = element;
    }

    public String getElement() {
        return element;
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone();
    }

    @Override
    public String toString() {
        return "Box{" +
                "element='" + element + '\'' +
                '}';
    }
}
// try catch finally 직접처리.. throws Exception 전달..
// new throw Exception();   예외 개발자가 직접 발생 시킴..
public class Ex01 {
    public static void main(String[] args) throws Exception {
        Box box1 = new Box("사과");
//        Box box2 = box1;
        Box box2 = new Box(box1.getElement());
//        Box box2 = (Box) box1.clone();
        box1.setElement("바나나");

        System.out.println(box1);
        System.out.println(box2);
    }
}
