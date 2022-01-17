package ccc;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

/*
 * 이미 클래스 파일을 만들었는데 클래스명을 바꾸고 싶다..
 * 이클립스...ctrl + 1 에러처리 
 * 인텔리제이에서는... alt + enter
 * 
 * @Configuration 환경설정
 * @Bean 객체담는통안에 객체 넣기
 * @Import 다른 환경 가져오기
 * @Autowird 객체담는통안에 있는 객체 자동으로 가져오기( 혹시나 객체가 없으면 에러가 난다)
 */
public class MyMain1 {
	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac
		 = new AnnotationConfigApplicationContext(MyConf.class);
		
		AA aa1 = acac.getBean(AA.class);
		AA aa2 = acac.getBean(AA.class);
		
		System.out.println("aa1  = "+aa1);
		System.out.println("aa2  = "+aa2);
		aa1.doA();
		
		BB bb1 = acac.getBean(BB.class);
		bb1.dob();
		
		CC cc1 = acac.getBean(CC.class);
		cc1.doCC();
		
		acac.close();
	}
}
