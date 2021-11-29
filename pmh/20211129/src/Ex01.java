import java.util.ArrayList;
import java.util.List;

/*
컬렉션과 제네릭을.. 같이 쓰면됩니다.

python ->
list -0 숫자형 -1
문자열 -2,,set,,dict,,

Java ->
List,
Set,
Map

 */
public class Ex01 {
    public static void main(String[] args) {
        // java 배열기반...배열의 범위벗어나게되면 ArrayIndexofbound
        List<String> slist = new ArrayList<>();
        List<Integer> ilist = new ArrayList<>();

        slist.add("문자열1");
        slist.add("문자열2");
        slist.add("문자열3");
//        slist.add(111);

        ilist.add(1); ilist.add(2); ilist.add(3);

        System.out.println(slist);
        System.out.println(ilist);


    }
}
