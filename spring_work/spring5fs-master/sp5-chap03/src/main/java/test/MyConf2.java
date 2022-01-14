package test;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.context.annotation.Bean;

public class MyConf2 {
	
	@Autowired
	@Qualifier("memberdao1")
	MemberDao md;
	
	@Bean
	public MemberService memberservice() {
		return new MemberService(md);
	}
	
	

}
