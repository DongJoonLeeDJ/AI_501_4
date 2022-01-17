package aaa.web.cc;

import org.springframework.stereotype.Component;

@Component // @Configuration @Bean 객체담는 통에 객체 주입
// @Component 객체담는통에 객체 주입
public class AA {

	public String getString() {
		return "AA class getString";
	}
}
