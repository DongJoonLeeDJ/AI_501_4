import java.util.*;

class A implements Comparator<String> {
    @Override
    public int compare(String o1, String o2) {
        return o2.length()-o1.length();
    }
}
public class Ex01 {
    public static void main(String[] args) {
/*        List<String> list = new ArrayList<>();
        list.add("Robot");
        list.add("Box");
        list.add("Ramda");
        Double*/
        List<String> list =
                Arrays.asList("Robot","Box","Ramda","A","BB");

        Collections.sort(list, new A() );
        Collections.sort(list,
            (String o1,String o2)-> o2.length()-o1.length()
        );
        System.out.println(list);
    }
}
