package chap09.todo;

import java.util.List;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

@Repository
public class TodoDao {
	
	@Autowired
	SqlSessionTemplate sst;
	
	public List<TodoDto> selectall() {
		List<TodoDto> list
			= sst.selectList("todo.selectall");
		return list;
	}
}
