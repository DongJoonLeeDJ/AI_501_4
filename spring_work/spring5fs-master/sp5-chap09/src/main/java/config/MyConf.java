package config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;

import mybeans.AA;

@Configuration
@ComponentScan(basePackages = {"chap09.member","chap09.todo"})
public class MyConf {

	public MyConf() {
	}
	
	@Bean
	public AA aa() {
		return new AA();
	}
}
