package config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import mybeans.AA;

@Configuration
public class MyConf {

	public MyConf() {
		System.out.println("myConf 생성자 호출");
	}
	
	@Bean
	public AA aa() {
		return new AA();
	}
}
