package chap09.member;

import java.util.Arrays;
import java.util.List;

import org.springframework.stereotype.Repository;

@Repository
public class MemberDao {

	public List<MemberDto> selectall() {
		List<MemberDto> list = Arrays.asList(
				new MemberDto(1,"aaa@naver.com","1234","남자"),
				new MemberDto(2,"bbb@naver.com","4567","여자"));
		return list;
	}

}
