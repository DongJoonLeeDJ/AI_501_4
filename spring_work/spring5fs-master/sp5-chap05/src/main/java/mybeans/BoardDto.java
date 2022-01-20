package mybeans;

public class BoardDto {

	private String name;
	private int age;

	public BoardDto(String name, int age) {
		this.name = name;
		this.age = age;
	}

	@Override
	public String toString() {
		return "BoardDto [name=" + name + ", age=" + age + "]";
	}
	
}
