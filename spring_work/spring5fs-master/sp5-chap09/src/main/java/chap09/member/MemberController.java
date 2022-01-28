package chap09.member;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;



@Controller
@RequestMapping(value = "member")
public class MemberController {
	
	@Autowired
	MemberService ms;
	
	@GetMapping(value = "selectall")
	public String selectall(Model model) {
		model.addAttribute("list", ms.selectall());
		return "member/selectall";
	}
	
	@GetMapping(value = "memberform")
	public String memberform(Model model) {
		return "member/memberform";
	}
	
	@PostMapping(value = "memberinsert")
	public String memberinsert(MemberDto memberdto) {
		ms.insert(memberdto);
		return "redirect:selectall";
	}

}
