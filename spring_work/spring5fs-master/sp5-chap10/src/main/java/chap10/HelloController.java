package chap10;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HelloController {
	
	/*
	 * tomcat 설정 상..
	 * url 맵핑 할때 
	 * 
	 * 우선순위 1
	 * wepapp/폴더 밑에 있는 index.html
	 * 
	 * 우선순위 2
	 * controller 에 등록된
	 * spring 5버전 
	 * @Getmapping, @Postmapping,
	 * spring 3버전.. 
	 * @RequestMapping(value = "/")
	 * 
	 * 회사연혁이 오래 되었을 수록 옛날 소스가 많아요...
	 * 스타트업을 ... 새로운 소스가 많은 편입니다... 
	 * 
	 */

//	@GetMapping("/")
	@RequestMapping(value = "/",method = RequestMethod.GET)
	public String hello(Model model) {
		return "index";
	}
	
}
