package mh.member;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class MemberService {
	@Autowired
	MyMemberDao memberdao;
	
	public void insert(Member member) {
		memberdao.insert(member);
	}

}
