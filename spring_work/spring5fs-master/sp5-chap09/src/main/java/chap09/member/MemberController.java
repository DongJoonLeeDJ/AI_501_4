package chap09.member;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.List;

import org.apache.tomcat.jdbc.pool.DataSource;
import org.mybatis.spring.SqlSessionFactoryBean;
import org.mybatis.spring.SqlSessionTemplate;
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
	
	@Autowired
	DataSource datasource;
	
//	@Autowired
//	SqlSessionFactoryBean ssfb;
	
	@Autowired
	SqlSessionTemplate ss;
	
	@GetMapping(value = "selectall")
	public String selectall(Model model) {
		
		System.out.println("datasource toString() 함수 호출됨 \n"+datasource);
//		System.out.println("ssfb toString() 함수 호출됨 \n"+ssfb);
		System.out.println("ss toString() 함수 호출됨 \n"+ss);
		ss.insert("members.insert",new MemberDto(2, "dd@naver.com", "123123", "남"));
		ss.insert("members.insert",new MemberDto(3, "bb@naver.com", "5563", "여"));
		ss.insert("members.insert",new MemberDto(4, "cc@naver.com", "1277823", "여자"));
		List<MemberDto> list = ss.selectList("members.selectall");
		
//		Connection conn = null;
//		PreparedStatement pstmt = null;
//		try {
//			conn = datasource.getConnection();
//			pstmt = conn.prepareStatement("delete from member");
//			pstmt.executeUpdate();
//			System.out.println("삭제됨.....");
//		}catch (Exception e) {
//			e.printStackTrace();
//		}
//		finally {
//			try {
//				pstmt.close();
//				conn.close();
//			}catch (Exception e) {
//			}
//		}
		
		
//		List<MemberDto> list = ms.selectall();
		model.addAttribute("list", list);
		return "member/selectall";
	}

}
