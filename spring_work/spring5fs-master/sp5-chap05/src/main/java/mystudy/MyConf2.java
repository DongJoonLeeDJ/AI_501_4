package mystudy;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import mybeans.BoardDao;
import mybeans.BoardService;

@Configuration
public class MyConf2 {

	@Autowired
	BoardDao boarddao;
	
	@Bean
	public BoardService boardservice() {
		return new BoardService(boarddao);
	}
}
