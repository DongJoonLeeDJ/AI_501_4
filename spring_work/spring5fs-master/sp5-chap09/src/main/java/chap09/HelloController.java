package chap09;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

import mybeans.AA;

@Controller
public class HelloController {
	
	@Autowired
	AA aa;
	
	@GetMapping("/hello")
	public String hello(Model model,
			@RequestParam(value = "name", required = false) String name) {
		System.out.println(aa);
//		model.addAttribute("greeting", "안녕하세요, " + name);
//		model.addAttribute("aaa", "bbbb");
		return "hello";
	}
	
}
