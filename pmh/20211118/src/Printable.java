public interface Printable {
    int PAPER_WIDTH = 70;
    int PAPER_HEIGHT = 120;
    void print(String doc);
    default void printCMYK(String doc){
        System.out.println("컬러로출력");
        print(doc);
    }
}
