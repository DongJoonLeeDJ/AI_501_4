import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.List;

public class Ex04 {

    public static void main(String[] args) {
        List<String> list =
                Arrays.asList("Robot", "Box", "Ramda", "A", "BB");  // immutable 변경불가능하다..
        List<String> list1 = new ArrayList<>(list); //mutable 변경가능하게 바꿈

//        list1.removeIf( (s) -> s.length() > 3 );
        list1.forEach( (s) -> System.out.println("s = "+s) );

//        for (String a : list1) {
//            if (a.length() > 3) {
//                System.out.println("지워야함");
//                list1.remove(a);
//            }
//        }

//        for(String a : list1){
//            System.out.println("a = "+a);
//        }

//        list1.remo
//        list1.forEach();// Consumer

//        System.out.println(list1);
    }
}
