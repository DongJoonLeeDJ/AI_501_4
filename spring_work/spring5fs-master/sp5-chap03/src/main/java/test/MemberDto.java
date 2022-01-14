package test;

public class MemberDto {

	private String name;
	private int age;

	// alt shift s -> o 생성자 생성
	public MemberDto(String name, int age) {
		super();
		this.name = name;
		this.age = age;
	}
	// alt shift s -> s toString
	@Override
	public String toString() {
		return "MemberDto [name=" + name + ", age=" + age + "]";
	}
	// alt shift s -> r getter setter
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	
	
	
}
