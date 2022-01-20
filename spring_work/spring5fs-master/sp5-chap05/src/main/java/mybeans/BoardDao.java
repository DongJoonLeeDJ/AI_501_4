package mybeans;

import org.springframework.stereotype.Component;

@Component
public class BoardDao {

	public void selectall() {
		System.out.println("select * from board 실행했음..");
	}

	public void insert(BoardDto dto) {
		System.out.println(dto+"insert into value 실행했음..");
	}

}
