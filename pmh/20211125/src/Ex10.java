import java.util.Arrays;

/*
20-2
1. 앞서 제시한 예제 ArrayObjSort.java에서는 Person의 인스턴스들을 나이순으로 정력하였는데
이를 수정하여 나이를 역순으로 정렬이 되도록 해보자. 다시 말해서, 많은 나이의 인스턴스일수록
배열의 앞쪽에 위치하도록 예제를 수정해보자

2. 앞서 제시한 예제 ArrayObjSort.java에서는 Person의 인스턴스들을 나이순으로 정력하였는데
이를 수정하여 이름의 길이 순으로 정렬이 되도록 수정해보자.
즉 이름이 길이가 짧은 인스턴스 일수록
배열의 앞쪽에 위치하도록 예제를 수정해야 한다.
 */

class Person implements Comparable {
    private String name;
    private int age;
    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }
    @Override
    public int compareTo(Object obj) {
        return  this.name.length()- ((Person) obj).name.length();
    }
    @Override
    public String toString() {
        return "Person{" +
                "name='" + name + '\'' +
                ", age=" + age +
                '}';
    }
}
// 인터페이스 comparable 상속받아서 compareTo 메서드를 재정의하면..
// Arrays.sort() 함수 사용 가능

// 인터페이스 clonable 상속받아서 clone 메서드를 재정의하면
public class Ex10 {
    public static void main(String[] args) {
        Person people[] = new Person[5];
        people[0] = new Person("aa",20);
        people[1] = new Person("bbb",10);
        people[2] = new Person("c",5);
        people[3] = new Person("dddd",33);
        people[4] = new Person("cee",22);
        for (Person p : people){
            System.out.println(p);
        }

        Arrays.sort(people);
        System.out.println();

        for (Person p : people){
            System.out.println(p);
        }
    }
}
