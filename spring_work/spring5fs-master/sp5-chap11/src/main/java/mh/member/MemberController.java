package mh.member;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("member")
public class MemberController {
	
	// 화면 폼... insert

	@Autowired
	MemberService ms;
	
	@GetMapping("insert")
	public String getinsert(Model model) {
		model.addAttribute("aa", "AA");
		model.addAttribute("memberForm",
				new MemberForm(0, "aa@an.com", "123", "남자"));
		return "member/insert";
	}
	@PostMapping("insert")
	public String postinsert(Model model, MemberForm memberForm) {
		return "member/insert";
	}
}
