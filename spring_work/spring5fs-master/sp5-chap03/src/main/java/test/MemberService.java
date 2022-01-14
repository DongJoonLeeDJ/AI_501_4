package test;

public class MemberService {
	
	private MemberDao md;

	public MemberService(MemberDao md) {
		this.md = md;
	}
	
	public void callInsert(MemberDto dto) {
		System.out.println("md.insert호출전");
		md.doInsert(dto);
		System.out.println("md.insert호출후");
	}

	public void callList() {
		md.doList();
	}

}
