package aa;

public class Member {

	private String name;
	private int age;
	
	void setName(String name) {
		this.name = name;
	}
	void setAge(int age) {
		this.age = age;
	}
	// alt + shift + s -> r
	
	void print() {
		System.out.println("MemberClass");
		System.out.println("name = "+name);
		System.out.println("age = "+age);
	}

	
}
