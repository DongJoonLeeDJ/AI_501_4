import java.util.Arrays;
import java.util.Comparator;

// cloneable -> clone, comparable->compareTo
// StringTokeniger, wrapperClass(Integer,Double,Long),
// Integer.parseInt, Double.parseDouble
// Random
class Person{
//class Person implements Comparable{
    private String name;
    private int age;

    public int getAge() {
        return age;
    }

    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }
    @Override
    public String toString() {
        return "Person{" + "name='" + name + '\'' + ", age=" + age +'}';
    }

//    @Override
//    public int compareTo(Object o) {
//        return this.age - ((Person)o).age;
//    }
}
public class Ex01 {
    public static void main(String[] args) {
        /*
        int ary[] = {5,2,3,1,4};    //기본형타입
        for( int temp : ary){
            System.out.print(temp+" ");
        }
        Arrays.sort(ary);
//        Arrays.sort();
        System.out.println();
        for( int temp : ary){
            System.out.print(temp+" ");
        }
         */
        Person pary[] = new Person[3];
        pary[0] = new Person("a",10);
        pary[1] = new Person("bb",20);
        pary[2] = new Person("ccc",5);
        for(Person temp:pary){
            System.out.println("temp = "+temp);
        }
        Arrays.sort(pary, (o1,o2)->{
            return o1.getAge() - o2.getAge();
        });
        for(Person temp:pary){
            System.out.println("temp = "+temp);
        }

    }
}
