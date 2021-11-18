public interface Printable {
    int PAPER_WIDTH = 70;
    int PAPER_HEIGHT = 120;
    void print(String doc);
    default void printCMYK(String doc){
        System.out.println("컬러로출력");
        print(doc);
    }
    static void staticPrint(String doc){
        System.out.println("스테틱은 객체생성하지 않고...");
        System.out.println(doc);
    }
}
