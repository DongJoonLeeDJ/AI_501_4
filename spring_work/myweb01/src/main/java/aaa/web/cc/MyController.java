package aaa.web.cc;

import java.util.Arrays;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
/*
 * @Controller
 * 요청되는 주소 맵핑시키는 역활...
 * 
 * @GetMapping
 * get방식으로 주소 요청..
 */
@Controller
public class MyController {
	@Autowired
	AA aa;
	
	@GetMapping(value = "aa")
	public String aa(Model model) {
		String ret = aa.getString();
		System.out.println(ret);
		model.addAttribute("ret",ret);
		List<String> list = Arrays.asList("aaa","bbb","ccc");
		model.addAttribute("list", list);
		return "aa";
	}

}
