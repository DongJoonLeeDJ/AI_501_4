package chap02;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class MyBeanMain {

	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac 
		= new AnnotationConfigApplicationContext(MyBeanFactory.class);
		
		AA a1 = acac.getBean(AA.class);
		System.out.println(a1);
		AA a2 = acac.getBean(AA.class);
		System.out.println(a2);
		
		acac.close();
		
		System.out.println();
		// ctrl + d 한줄삭제
		// ctrl + space  해당되는거 enter
		
	}
}
