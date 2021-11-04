import aa.bb.cc.Person;

/*
    class new
    public protected default private
    static
    메서드 오버로딩
    생성자 오버로딩
 */

public class Ex02 {
    public static void main(String[] args) {
        Person p1 = new Person();
        System.out.println("p1 "+ p1.toString());
        System.out.println("p1 "+ p1);

        Person p2 = new Person("홍길동");
        System.out.println("p2 "+p2);
        System.out.printf("a = %d ",2);
        System.out.printf("b = %d\n",233);
        // shift + delete
    }
}
