package chap09.member;

public class MemberPage {
	
	// jsp 페이지에서 page 파라메타
	private int page;
	// db에서 limit 변수
	private int pageNumber;
	
	// 총 행의 개수
	private int totalrow;
	// 총 페이지 개수
	private int pagecnt;
	
	public int getTotalrow() {
		return totalrow;
	}

	public void setTotalrow(int totalrow) {
		this.totalrow = totalrow;
	}

	public int getPagecnt() {
		return pagecnt;
	}

	public void setPagecnt(int pagecnt) {
		this.pagecnt = pagecnt;
	}

	public int getPage() {
		return page;
	}

	public void setPage(int page) {
		this.page = page;
	}

	public int getPageNumber() {
		return pageNumber;
	}

	public void setPageNumber(int pageNumber) {
		this.pageNumber = pageNumber;
	}
	
}
