package mytest;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.context.support.GenericXmlApplicationContext;

/*
 * spring 객체 담는통안에 같은클래스 두개 들어가있을 때 구분하는 역활..
 * @Qualifier
 * 
 * spring - mybatis
 * 
 * springboot - jpa
 * 
 */
public class MyMain {
	public static void main(String[] args) {
//		AnnotationConfigApplicationContext acac = 
//				new AnnotationConfigApplicationContext(MyConf.class);
		
		GenericXmlApplicationContext acac = 
				new GenericXmlApplicationContext("./mytest/myconf.xml");
		
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
