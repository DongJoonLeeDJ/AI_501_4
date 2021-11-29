import java.util.HashMap;
import java.util.Map;
import java.util.Set;

/*
    List, Set, Map

    1. list.... 반복자.. 향상된 for...
    배열기반의 자료형타입들...
    0번째 1번째 2번째.. 중복을 허용한다.

    2. Set... 반복자.. 향상된 for... -> 주소값비교.. 내용비교.. equals
    중복을 허용하지 않는 자료들을 넣으면 된다..

    3. map 키와 값을 쌍으로 이루어져 있고.. 파이썬에서 dict와 돌일한 자료형
        반복자 X , keySet함수를 사용을 해야한다.
        중복은 키는 허용하지 않고 값을 허용한다...
        1 -> aa 1-> bb??불가능하다..
        1 -> aa 2-> aa 가능핟...
 */

public class Ex05 {

    public static void main(String[] args) {
        Map<Integer,String> map = new HashMap<>();

        map.put(1,"aaa");
        map.put(2,"bbb");
        map.put(3,"ccc");

        System.out.println(map);

        System.out.println(map.get(1));
        System.out.println(map.get(2));
        System.out.println(map.get(3));

//        System.out.println(map[1]);

//        for( ?? : map)
        System.out.println();
        Set<Integer> keys = map.keySet();
        for( Integer key:keys ){
            System.out.println(map.get(key));
        }
    }
}








