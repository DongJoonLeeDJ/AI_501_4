package config;

import static java.lang.annotation.ElementType.TYPE;
import static java.lang.annotation.RetentionPolicy.RUNTIME;

import java.lang.annotation.ElementType;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;
import java.lang.annotation.Target;

@Retention(RUNTIME)
//@Retention(RetentionPolicy.SOURCE)
@Target(TYPE)
//@Target(ElementType.METHOD)
//@Target(ElementType.FIELD)
public @interface ManualBean {

}
