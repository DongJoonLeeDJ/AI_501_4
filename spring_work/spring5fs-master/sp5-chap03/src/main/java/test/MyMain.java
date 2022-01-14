package test;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

/*
 * @Configutraion	이 파일은 스프링 객체담는 설정 하는 파일...
 * @Bean			객체담아라...
 * 
 * @autowird -> 요거는 뭐야...
 * 
 */
public class MyMain {
	
	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac = 
			new AnnotationConfigApplicationContext(MyConf.class);
		
//		MemberDao md = acac.getBean(MemberDao.class);
//		md.doInsert();
		
		MemberService ms = acac.getBean(MemberService.class);
		
		ms.callInsert(new MemberDto("홍길동", 20));
		ms.callInsert(new MemberDto("김길동", 21));
		ms.callInsert(new MemberDto("이길동", 22));
		
		ms.callList();
		
		acac.close();
		
	}
}
