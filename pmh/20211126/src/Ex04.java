class Box<T>{
    private T obj;
    public Box(T obj) {
        this.obj = obj;
    }
    public T get() {   return obj;   }
    @Override
    public String toString() {
        return "Box{" + "obj=" + obj + '}';
    }
}
public class Ex04 {
    public static void main(String[] args) {
        Box<Apple> aBox = new Box(new Apple("사과"));
        Box<Banana> oBox = new Box(new Banana("바나나"));

        Apple aple = aBox.get();
        Banana Bana = oBox.get();

        System.out.println(aple);
        System.out.println(Bana);

    }
}
