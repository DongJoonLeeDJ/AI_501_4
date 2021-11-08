class Box{
    // 생성자 toString
    // alt + insert
    private String conts;
    public Box(String conts) {
        this.conts = conts;
    }
    @Override
    public String toString() {
        return "Box{" +
                "conts='" + conts + '\'' +
                '}';
    }
}
public class Ex06 {
    public static void main(String[] args) {
        Box boxs[] = new Box[3];
        for ( Box temp: boxs ) {
            System.out.println("temp = " + temp);
        }

        boxs[0] = new Box("사과");
        boxs[1] = new Box("바나나");
        boxs[2] = new Box("수박");

        for ( Box temp: boxs ) {
            System.out.println("temp = " + temp);
        }

    }
}











