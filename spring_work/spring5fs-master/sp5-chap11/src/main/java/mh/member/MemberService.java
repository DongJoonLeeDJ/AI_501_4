package mh.member;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;

@Service
public class MemberService {
	@Autowired
	MyMemberDao memberdao;
	
	public void insert() {
		memberdao.insert();
	}

}
