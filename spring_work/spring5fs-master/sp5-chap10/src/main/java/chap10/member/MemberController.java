package chap10.member;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("member")
public class MemberController {
	
	@Autowired
	SqlSessionTemplate sst;
	

	@GetMapping("selectall")
	public String selectall() {
		Member member = sst.selectOne("members.selectone");
		System.out.println(member);
		return "member/selectall";
	}
}
