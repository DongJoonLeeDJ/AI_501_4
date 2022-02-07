package chap09.todo;

import java.util.List;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
@RequestMapping(value = "todo")
public class TodoController {
	
	@Autowired
	SqlSessionTemplate sst;
	
	@Autowired
	TodoService todoservice;
	
	@GetMapping(value = "delete")
	public String delete(Model model,int idx) {
		sst.delete("todo.delete",idx);
		return "redirect:selectall";
	}
	
	@GetMapping(value = "selectall")
	public String selectall(Model model) {
		List<TodoDto> list = todoservice.selectall();
		model.addAttribute("list",list);
		return "todo/selectall";
	}
	
	@GetMapping(value = "insert")
	public String insert(Model model) {
		TodoDto tododto = new TodoDto(0,"","");
		model.addAttribute("tododto", tododto);
		return "todo/insert";
	}
	
	@PostMapping(value = "insert")
	public String insert(TodoDto dto) {
		dto.setWdate("20220204");
		sst.insert("todo.insert",dto);
		return "redirect:selectall";
	}

}
