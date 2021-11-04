package aa.bb.cc;

public class Person {
    //기본생성자는 생략...
    private String name;
    public Person(){}
    public Person(String n){
        name = n;
    }

    // alt + insert 소스 자동 단축키..

    // 소스 자동 완성 문법 많이 쓰는것 3가지..
    // 1. setter getter 
    // 2. constructor 생성자 
    // 3. toString 클래스 대표 메서드

    @Override
    public String toString() {
        return "Person{ name : "+name+" }";
    }


//    public String toString(){
//        return "Person";
//    }
}
