package chap09.todo;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping(value = "todo")
public class TodoController {
	
	/*
	 * 1교시 복습.. Controller,Service,dao,dto..
	 * 2교시 DataSources 연결.. 커넥션..
	 * 
	 * 3~4 mybatis
	 */
	
	
	
	
	@GetMapping(value = "selectall")
	public String selectall(Model model) {
		return "todo/selectall";
	}

}
