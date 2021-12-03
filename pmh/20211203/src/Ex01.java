import java.lang.annotation.*;
import java.lang.reflect.Field;
import java.lang.reflect.Method;

@Target({ElementType.FIELD, ElementType.METHOD, ElementType.TYPE})       // 클래스,, 메서드,, 변수,,
@Retention(RetentionPolicy.RUNTIME)    // 실행도중,, 소스로만,,
@interface MyAnnotation {
    String a() default "aa";
    int b() default 10;
}

@MyAnnotation(a="Ex01",b=400)
public class Ex01 {
    Ex01() {
        //변수 가져오는 함수
        Field fields[] = this.getClass().getDeclaredFields();
        for (Field f : fields) {
            System.out.println(f);
            Annotation ao = f.getAnnotation(MyAnnotation.class);
            System.out.println(ao);
        }
        // 메서드 가져오는 함수
        Method methods[] = this.getClass().getDeclaredMethods();
        for (Method f : methods) {
            System.out.println(f);
            Annotation ao = f.getAnnotation(MyAnnotation.class);
            System.out.println(ao);
        }
        // Ex01클래스에 붙은 어노테이션 가져오는 함수
        MyAnnotation[] ma = this.getClass().getAnnotationsByType(MyAnnotation.class);
        System.out.println(ma[0].a());
        System.out.println(ma[0].b());
//        Annotation anno =  this.getClass().getAnnotation(MyAnnotation.class);
    }

    @MyAnnotation
    String s1 = "f";

    @MyAnnotation(a = "aaa", b = 20)
    int s2 = 10;

    @MyAnnotation(a = "doAmethod", b = 30)
    public void doA() {
    }

    public static void main(String[] args) {
        new Ex01();
    }
}
