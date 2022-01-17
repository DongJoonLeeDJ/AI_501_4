package ccc;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Import;

@Configuration
@Import(MyAutoConf.class)
public class MyConf {

	@Bean
	public AA aa() {
		return new AA();
	}
	
	@Bean
	public BB bb() {
		return new BB();
	}
}
