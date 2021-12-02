import java.lang.annotation.ElementType;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;
import java.lang.annotation.Target;

// 람다.. 문법 더 어려운거...

@Target({ElementType.FIELD,ElementType.TYPE,ElementType.METHOD})   // 어디에 붙여 쓸 것인지 설정, 변수,,메서드,,클래스,,
@Retention(RetentionPolicy.RUNTIME)    // 소스적으로만 설정, 실행할때 설정
public @interface MyAnnotation {
    String value() default "HIHI";
    int num() default 10;
}

