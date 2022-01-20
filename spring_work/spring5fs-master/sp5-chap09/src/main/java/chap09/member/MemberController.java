package chap09.member;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping(value = "member")
public class MemberController {
	
	@GetMapping(value = "selectall")
	public String selectall() {
		return "member/selectall";
	}

}
