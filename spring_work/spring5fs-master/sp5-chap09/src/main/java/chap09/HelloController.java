package chap09;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HelloController {
	
	@GetMapping("/index")
	public String index(Model model) {
		return "index";
	}
	
	@GetMapping("/hello")
	public String hello(Model model,
			@RequestParam(value = "name", required = false) String name) {
		return "hello";
	}
	
}
