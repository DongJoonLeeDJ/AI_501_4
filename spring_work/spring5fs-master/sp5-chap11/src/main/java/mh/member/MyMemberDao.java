package mh.member;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

@Repository
public class MyMemberDao {
	
	@Autowired
	SqlSessionTemplate sst;
	
	public void insert(Member member) {
		sst.insert("members.insert",member);
	}

}
