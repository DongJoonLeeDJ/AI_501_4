import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

public class Ex04 {
    public static void main(String[] args) {
        Set<Row> rset = new HashSet<>();
        rset.add(new Row("aa",100,90,80));
        rset.add(new Row("aa",100,90,80));
        System.out.println(rset);

//        Set<String> set = new HashSet<>();
//        set.add("Box"); set.add("TOM");
//        set.add("Box"); set.add("ROBOT");
//
//        System.out.println(set.size());
//
//        System.out.println(set);
//        System.out.println();
//        Iterator<String> itr =  set.iterator();
//        while(itr.hasNext()){
//            System.out.println(itr.next());
//        }
//        System.out.println();
//        for( String s : set){
//            System.out.println(s);
//        }
//        System.out.println();
    }
}
