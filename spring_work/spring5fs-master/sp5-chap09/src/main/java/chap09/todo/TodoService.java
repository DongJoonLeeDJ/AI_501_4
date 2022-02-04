package chap09.todo;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class TodoService {
	
	@Autowired
	TodoDao dotodao;
	
	public List<TodoDto> selectall() {
		List<TodoDto> list = dotodao.selectall();
		return list;
	}
	
}
