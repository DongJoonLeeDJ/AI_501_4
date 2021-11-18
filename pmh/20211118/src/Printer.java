// 부모 클래스 ... 참조변수로 활용이 가능하다..
// 다형성...

// ->(); 람다....

// 상속받았으면 상속받은 인터페이스안에 매서드 재정의.. 규칙..
public class Printer implements Printable {
    public static void main(String[] args) {
        Printable prn = new Printer();
        prn.print("기본 생성방법");

        /*
        Printable prn2 = (aa)->{
            System.out.println("방금만든람다.");
        };
        Printable prn3 = new Printable() {
            @Override
            public void print(String doc) {
            }
        };
       */
    }
    @Override
    public void print(String doc) {
        System.out.println(doc+" override ....");
    }
}









