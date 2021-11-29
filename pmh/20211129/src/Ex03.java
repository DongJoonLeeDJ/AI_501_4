import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Objects;
/*
    Interface .... 함수형..으로...
    람다...

    javascript...

    function doA(a,b){
        b();
    }

    doA(a, function(){ let c = a*b; alert(c)} );

 */
class Row{
//class Row implements Comparable<Row>{
    private String name;
    private int kor;
    private int eng;
    private int math;
    public int total;

    public Row(String name, int kor, int eng, int math) {
        this.name = name;
        this.kor = kor;
        this.eng = eng;
        this.math = math;
        this.total = kor + eng + math;
    }

    /*
//    @Override
//    public boolean equals(Object o) {
//        Row row = (Row) o;
//        return this.kor == row.kor
//                && this.eng == row.eng
//                && this.math == row.math
//                && this.total == row.total
//                && Objects.equals(this.name, row.name);
//    }

    public int hashCode() {
        return Objects.hash(name, kor, eng, math, total);
    }
     */

    @Override
    public String toString() {
        return "Row{" +
                "name='" + name + '\'' +
                ", kor=" + kor +
                ", eng=" + eng +
                ", math=" + math +
                ", total=" + total +
                '}';
    }

//    @Override
//    public int compareTo(Row o) {
//        return this.total - o.total;
//    }
}
public class Ex03 {
    public static void main(String[] args) {

        List<Row> al = new ArrayList<>();
        al.add(new Row("aa",100,80,70));
        al.add(new Row("bbb",90,70,60));
        al.add(new Row("cccc",70,90,80));

        System.out.println(al);

        Collections.sort(al, (o1, o2) -> ((Row)o1).total-((Row)o2).total );

        System.out.println(al);

    }
}
