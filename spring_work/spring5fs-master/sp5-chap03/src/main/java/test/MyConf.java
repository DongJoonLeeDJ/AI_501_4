package test;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Import;

@Configuration
@Import(MyConf2.class)
public class MyConf {
	
	@Bean
	@Qualifier("memberdao1")
	public MemberDao memberdao1() {
		return new MemberDao();
	}
	
	@Bean
	@Qualifier("memberdao2")
	public MemberDao memberdao2() {
		return new MemberDao();
	}

}
