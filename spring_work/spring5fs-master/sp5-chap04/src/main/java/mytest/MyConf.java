package mytest;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class MyConf {
	
	@Bean
	public MemberDao memberdao() {
		return new MemberDao();
	}

}
