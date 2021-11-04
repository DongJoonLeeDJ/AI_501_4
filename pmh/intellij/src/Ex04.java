class AA{
    private int num;
    // 자동 소스 단축키
    // alt insert -> constructor (생성자)
    public AA(int num) {
        this.num = num;
    }
    @Override
    public String toString() {
        return "AA{" +
                "num=" + num +
                '}';
    }
}
public class Ex04 {
    public static void main(String[] args) {
        AA a1 = new AA(100);
        System.out.println(a1.toString());
    }
}
