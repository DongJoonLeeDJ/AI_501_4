package chap09;

import org.springframework.beans.factory.annotation.Autowired;

public class MemberService {
	
	@Autowired
	MemberDao dao;
	
	public void insert() {
		dao.insert(); // DB 저장로직..
	}

}
