package chap10.member;

import java.util.List;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

@Repository
public class MemberDao {
	
	@Autowired
	SqlSessionTemplate sst;

	public Member selectOne() {
		Member member = sst.selectOne("members.selectone");
		return member;
	}

	public List<Member> selectAll() {
		List<Member> list = sst.selectList("members.selectall");
		return list;
	}
	
//	public Member selectList() {
//		
//	}
//	public int insert() {
//		
//	}
//	public int update() {
//		
//	}
//	public int delete() {
//		
//	}
}
