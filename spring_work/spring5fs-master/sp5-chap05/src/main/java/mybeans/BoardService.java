package mybeans;

public class BoardService {

	private BoardDao boarddao;
	
	public BoardService(BoardDao boarddao) {
		this.boarddao = boarddao;
	}
	
	public void selectall() {
		boarddao.selectall();
	}
	
	public void insert(BoardDto dto) {
//		if(boarddao.selectByEmail()) {// 중복체크확인
			boarddao.insert(dto);
//		}
	}

}
