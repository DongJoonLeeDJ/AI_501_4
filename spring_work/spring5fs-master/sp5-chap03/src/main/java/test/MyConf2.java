package test;

import org.springframework.beans.factory.annotation.Autowired;

public class MyConf2 {
	
	@Autowired
	MemberDao md;
	
	public void callInsert() {
		System.out.println("md.insert호출전");
		md.doInsert();
		System.out.println("md.insert호출후");
	}

}
