import java.io.FileWriter;
import java.io.IOException;

class AA{
    public AA() throws IOException{
        System.out.println("AA생성자 호출할떄 IOException이 " +
                            "발생할 수도 있다는것을 명시..");
    }
}

public class Ex03 {
    public static void md1(){
        // try catch 문으로 감싸기
        // throws Excpetion 예외 다른곳에서 처리하라고 넘기기
        try {
            md2();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void md2() throws IOException {
        // try catch 문으로 감싸기 
        // throws Excpetion 예외 다른곳에서 처리하라고 넘기기
        FileWriter writer = new FileWriter("a.txt");
        writer.write("글을 씁니다.");
        writer.close();
    }

    public static void main(String[] args) throws IOException {
        md1();
        new AA();
    }
}
