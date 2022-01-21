package chap09.todo;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping(value = "todo")
public class TodoController {
	
	@GetMapping(value = "selectall")
	public String selectall(Model model) {
		return "todo/selectall";
	}

}
