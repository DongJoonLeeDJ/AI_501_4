package chap10.member;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class MemberService {
	
	@Autowired
	MemberDao dao;
	
	public Member selectone() {
		Member member = dao.selectOne();
		return member;
	}

	public List<Member> selectall(int page) {
		List<Member> list = dao.selectAll();
		return list;
	}

}
