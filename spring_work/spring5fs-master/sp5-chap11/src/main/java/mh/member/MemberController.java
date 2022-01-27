package mh.member;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("member")
public class MemberController {

	@Autowired
	MemberService ms;
	
	@GetMapping("insert")
	public String insert() {
		ms.insert();
		return "member/insert";
	}
}
