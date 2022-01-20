package mystudy;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Import;

import mybeans.A;
import mybeans.B;
import mybeans.BoardDao;

@Configuration
@ComponentScan(basePackages = { "mybeans" })
@Import(MyConf2.class)
public class MyConf {

//	@Bean
//	public BoardDao boarddao() {
//		return new BoardDao();
//	}
	
//	@Bean
//	public A a() {
//		return new A();
//	}
//	
//	@Bean 
//	public B b() {
//		return new B();
//	}

}
