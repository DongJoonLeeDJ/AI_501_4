package mystudy;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import mybeans.BoardDto;
import mybeans.BoardService;

public class Main {

	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac = 
			new AnnotationConfigApplicationContext(MyConf.class);

		BoardService bs = acac.getBean(BoardService.class);
		
		bs.selectall();
		bs.insert(new BoardDto("홍길동",20));
		bs.insert(new BoardDto("김길동",30));
		bs.selectall();
		
		acac.close();
	}
}
