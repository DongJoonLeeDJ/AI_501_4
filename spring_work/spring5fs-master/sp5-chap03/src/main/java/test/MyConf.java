package test;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Import;

@Configuration
@Import(MyConf2.class)
public class MyConf {
	
	@Bean
	public MemberDao memberdao() {
		return new MemberDao();
	}

}
