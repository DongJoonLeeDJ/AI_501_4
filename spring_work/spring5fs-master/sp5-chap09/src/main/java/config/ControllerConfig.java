package config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import chap09.HelloController;
import chap09.LoginController;

@Configuration
public class ControllerConfig {

	@Bean
	public HelloController helloController() {
		return new HelloController();
	}
	
	@Bean
	public LoginController loginController() {
		return new LoginController();
	}

}
