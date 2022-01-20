package chap09.member;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping(value = "member")
public class MemberController {
	
	@Autowired
	MemberService ms;
	
	@GetMapping(value = "selectall")
	public String selectall(Model model) {
		List<MemberDto> list = ms.selectall();
		model.addAttribute("list", list);
		return "member/selectall";
	}

}
