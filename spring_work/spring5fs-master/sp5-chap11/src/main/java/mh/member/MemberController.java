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
	
	@Autowired
	MemberService ms;
	
	@GetMapping("insert")
	public String getinsert(Model model) {
		model.addAttribute("aa", "GET");
		model.addAttribute("memberForm",
				new MemberForm(0, "aa@an.com", "123", "남자"));
		return "member/insert";
	}
	@PostMapping("insert")
	public String postinsert(Model model, MemberForm memberForm) {
		model.addAttribute("aa", "POST");
		Member member = new Member(
					memberForm.getIdx(),
					memberForm.getEmail(),
					memberForm.getPwd(),
					memberForm.getGender(),
					"2022/01/27"
					);
		ms.insert(member);
		return "redirect:/main";
	}
}
