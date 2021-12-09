/*
    consumer,,    predicate,,    Function,,    Supplier
 */

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Ex01 {
    public static void main(String[] args) {
        List<String> li = Arrays.asList("aa","bbb","cccc","dddd");
        List<String> li1 = new ArrayList<>(li);

        li1.stream()
            .filter(s -> s.length()>3)
            .forEach(s -> System.out.println(s));

        System.out.println();
        for (String temp : li){
            if (temp.length() > 2)
                System.out.println(temp);
        }

    }
}
