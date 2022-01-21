package chap09.todo;

// table 1:1맵핑
public class TodoDto {
	
	private int idx;
	private String todo;
	private String wdate;
	public TodoDto() {}
	public TodoDto(int idx, String todo, String wdate) {
		super();
		this.idx = idx;
		this.todo = todo;
		this.wdate = wdate;
	}
	
	public int getIdx() {
		return idx;
	}
	public void setIdx(int idx) {
		this.idx = idx;
	}
	public String getTodo() {
		return todo;
	}
	public void setTodo(String todo) {
		this.todo = todo;
	}
	public String getWdate() {
		return wdate;
	}
	public void setWdate(String wdate) {
		this.wdate = wdate;
	}
	@Override
	public String toString() {
		return "TodoDto [idx=" + idx + ", todo=" + todo + ", wdate=" + wdate + "]";
	}
}
