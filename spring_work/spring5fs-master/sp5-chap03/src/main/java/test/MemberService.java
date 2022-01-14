package test;

public class MemberService {
	
	private MemberDao md;

	public MemberService(MemberDao md) {
		this.md = md;
	}
	
	public void callInsert() {
		System.out.println("md.insert호출전");
		md.doInsert();
		System.out.println("md.insert호출후");
	}

}
