package chap02;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class MyBeanFactory {

	@Bean
	public AA aa() {
		return new AA();
	}
	
	@Bean
	public BB bb() {
		return new BB();
	}
}
