package mytest;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

/*
 * spring 객체 담는통안에 같은클래스 두개 들어가있을 때 구분하는 역활..
 * @Qualifier
 */
public class MyMain {
	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac = 
				new AnnotationConfigApplicationContext(MyConf.class);
		
		MemberDao md = acac.getBean(MemberDao.class);
		
		System.out.println("조회조회전");
		md.select();
		System.out.println("조회완료");
		
		md.insert(new MemberDto("홍길동",20));
		md.insert(new MemberDto("김길동",30));
		
		System.out.println("조회조회전");
		md.select();
		System.out.println("조회완료");
		
		acac.close();
	}

}
