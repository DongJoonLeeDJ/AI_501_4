import java.util.*;

/*
    컬렉션프레임워크... 제네릭..
    List<Person> 순서가 있는 자료형 타입으로 Person 객체를 추가 하거나 뺄 수 있다.
    Set<String> 순서가 없고 중복 허용이 되지 않는 자료형 타입
    Map<Key,Value> 한쌍의 객체를 넣을 수 있는 자료형 타입..

    Comparable 상속 받아서 compareTo 메서드 재정의 해서 정렬을
 */
class Person implements Comparable<Person>{
    public int age;
    private String name;
    // alt insert -> constructor 생성자 자동 완성..
    public Person(int age, String name) {
        this.age = age;
        this.name = name;
    }
    @Override
    public String toString() {
        return "Person{" +
                "age=" + age +
                ", name='" + name + '\'' +
                '}';
    }

    @Override
    public int compareTo(Person o) {
        System.out.println(o.age);
        System.out.println(this.age);
//        return this.age-o.age;
        return o.age-this.age;
    }
}

class MyComparator implements Comparator<Person>{
    @Override
    public int compare(Person o1, Person o2) {
        return o2.age-o1.age;
    }
}

public class Ex01 {
    public static void main(String[] args) {
//        Person p1 = new Person(20,"홍길동");
//        System.out.println(p1);
//        List<Person> list = new ArrayList<>();
//        list.add(p1);
//        System.out.println(list);

        List<Person> list = Arrays.asList(
                new Person(20,"홍길동"),
                new Person(30,"김길동"),
                new Person(40,"이길동")
                );

//        System.out.println(list);
        System.out.println(list.get(0));
        System.out.println(list.get(1));
        System.out.println(list.get(2));

        Collections.sort(list, new Comparator<Person>() {
            @Override
            public int compare(Person o1, Person o2) {
                return o2.age-o1.age;
            }
        });

        MyComparator mc = new MyComparator();

        Collections.sort(list, mc);
        Collections.sort(list, (o1,o2)-> o1.age-o2.age );

        System.out.println(list.get(0));
        System.out.println(list.get(1));
        System.out.println(list.get(2));
    }
}
















