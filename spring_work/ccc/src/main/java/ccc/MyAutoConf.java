package ccc;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class MyAutoConf {

	@Autowired
	AA aa;
	
	@Bean
	public CC cc() {
		return new CC(aa);
	}
	
	
}
