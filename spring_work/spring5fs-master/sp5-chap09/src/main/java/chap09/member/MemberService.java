package chap09.member;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class MemberService {
	
	@Autowired
	MemberDao memberdao;

	public List<MemberDto> selectall() {
		List<MemberDto> list = memberdao.selectall();
		return list;
	}

	public void insert(MemberDto memberdto) {
		memberdao.insert(memberdto);
	}

	public void update(MemberDto memberdto) {
		memberdao.update(memberdto);
	}
	
	public MemberDto selectone(int idx) {
		MemberDto dto = memberdao.selectone(idx);
		return dto;
	}

}
