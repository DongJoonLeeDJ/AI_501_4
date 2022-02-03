package chap09.member;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;



@Controller
@RequestMapping(value = "member")
public class MemberController {
	
	@Autowired
	MemberService ms;
	
	@Autowired
	SqlSessionTemplate ss;
	
	@GetMapping(value = "selectall")
	public String selectall(Model model) {
		model.addAttribute("list", ms.selectall());
		return "member/selectall";
	}
	
	// idx 가 값이 안들어오면.. 기본값으로 0을 선택한다.
	// String idx = request.getParameter("idx"); 
	@GetMapping(value = "memberform")
	public String memberform(Model model,
			@RequestParam(defaultValue = "0") int idx ) {
		MemberDto dto = new MemberDto(0,"","","","");
		if(idx!=0)
			dto = ms.selectone(idx);
		model.addAttribute("memberdto",dto);
		return "member/memberform";
	}
	
	@PostMapping(value = "memberinsert")
	public String memberinsert(MemberDto memberdto) {
		if(memberdto.getIdx()!=0)
			ms.update(memberdto);
		else
			ms.insert(memberdto);
		return "redirect:selectall";
	}
	
	@PostMapping(value = "delete")
	public String delete(int[] idxs) {
		ss.delete("members.delete");
		return "redirect:selectall";
	}

}
