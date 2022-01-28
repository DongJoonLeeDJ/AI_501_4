package chap09.member;

import java.util.List;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

@Repository
public class MemberDao {
	
	@Autowired
	SqlSessionTemplate ss;

	public List<MemberDto> selectall() {
//		List<MemberDto> list = Arrays.asList(
//				new MemberDto(1,"aaa@naver.com","1234","남자","20220128"),
//				new MemberDto(2,"bbb@naver.com","4567","여자","20220128"));
		List<MemberDto> list = ss.selectList("members.selectall");
		return list;
	}

}
