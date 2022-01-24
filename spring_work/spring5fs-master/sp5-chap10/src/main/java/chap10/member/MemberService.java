package chap10.member;

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

}
