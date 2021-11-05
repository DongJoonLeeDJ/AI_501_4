class Box{
    String name;
    public Box(String name) {
        this.name = name;
    }
    @Override
    public String toString() {
        return "Box{" +
                "name='" + name + '\'' +
                '}';
    }
}
public class Ex04 {
    public static void main(String[] args) {
        StringBuilder a = new StringBuilder("1234");
        System.out.println(a.toString());
        System.out.println(a);

        Box box = new Box("사과상자");
        System.out.println(box);
        System.out.println(box.toString());

    }
}
