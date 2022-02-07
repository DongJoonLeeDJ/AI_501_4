package chap09;

import javax.servlet.http.HttpSession;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;

import chap09.member.MemberDto;

@Controller
public class LoginController {
	
	@Autowired
	SqlSessionTemplate sst;

	@PostMapping(value = "login")
//	public String login(@RequestParam(value="email") String email,) {
//	public String login(String email,String pwd) {
	public String login(LoginReq loginReq,HttpSession session) {
		MemberDto dto = sst.selectOne("login.selectone",loginReq);
		if(dto!=null)
			session.setAttribute("login", dto);
		else
			return "loginform";
		return "redirect:/index";
	}

	@GetMapping(value = "logout")
	public String logout(HttpSession session) {
		session.invalidate();
		return "redirect:/index"; 
	}
}
