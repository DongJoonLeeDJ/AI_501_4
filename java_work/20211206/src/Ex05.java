import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.List;
import java.util.stream.Stream;

public class Ex05 {


    public static void main(String[] args) {
        List<Integer> list = Arrays.asList(1,2,3,4,5,6);

        List<Integer> list1 = new ArrayList<>(list);

        int sum = list1.stream()
//                    .filter( n-> n%2==0 )
                    .mapToInt( s -> s)
                    .sum();

        System.out.println(sum);
    }
}
