import java.lang.reflect.Field;
import java.lang.reflect.Method;

@MyAnnotation
public class Ex05 {

    @MyAnnotation
    String s1="first";

    @MyAnnotation(value = "Hello",num = 20)
    String s2="second";

    @MyAnnotation
    public static void main(String[] args) {
        Ex05 ex05 = new Ex05();
        Field[] fields = ex05.getClass().getDeclaredFields();
        Method[] methods = ex05.getClass().getDeclaredMethods();

        for ( Field e : fields){
            System.out.println(e);
            MyAnnotation ma = e.getAnnotation(MyAnnotation.class);
            System.out.println(ma.num());
            System.out.println(ma.value());
            System.out.println();
        }

    }
}
