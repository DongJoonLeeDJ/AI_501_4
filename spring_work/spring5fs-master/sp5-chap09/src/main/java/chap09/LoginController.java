package chap09;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PostMapping;

import chap09.member.MemberDto;

@Controller
public class LoginController {
	
	@Autowired
	SqlSessionTemplate sst;

	@PostMapping(value = "login")
//	public String login(@RequestParam(value="email") String email,) {
//	public String login(String email,String pwd) {
	public String login(LoginReq loginReq) {
		MemberDto dto = sst.selectOne("login.selectone",loginReq);
		
		return "redirect:/index";
	}
	
}
