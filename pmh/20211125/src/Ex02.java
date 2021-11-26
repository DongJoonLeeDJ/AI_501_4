import java.lang.Integer;

/*
    python 모든 자료형 타입은 래퍼 클래스다..
    a = 10
 */
public class Ex02 {
    public static void showData(Object obj){
        System.out.println(obj);
    }
    // 1.79...10**308
    public static void main(String[] args) {
        Integer iinst = new Integer(3);
        showData(iinst);
        System.out.println(Integer.MAX_VALUE);
        System.out.println(Integer.MIN_VALUE);

        Double dinst = new Double(7.15);
        showData(dinst);
        System.out.println(Double.MAX_VALUE);
        System.out.println(Double.MIN_VALUE);
        System.out.println(Double.SIZE);
    }
}
