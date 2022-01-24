package chap10.member;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
@RequestMapping("member")
public class MemberController {
	
	@Autowired
	MemberService ms;

	@GetMapping("selectall")
	public String selectall(Model model, @RequestParam(name ="page", defaultValue="1") int page) {
		System.out.println("page = "+page);
		model.addAttribute("member", ms.selectone());
		model.addAttribute("list", ms.selectall(1));
		return "member/selectall";
	}
}
