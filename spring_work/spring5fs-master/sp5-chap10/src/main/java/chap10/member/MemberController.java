package chap10.member;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("member")
public class MemberController {
	
	@Autowired
	MemberService ms;

	@GetMapping("selectall")
	public String selectall(Model model) {
		model.addAttribute("member", ms.selectone());
		return "member/selectall";
	}
}
