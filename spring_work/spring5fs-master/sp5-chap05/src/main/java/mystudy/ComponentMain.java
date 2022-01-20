package mystudy;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import mybeans.A;
import mybeans.B;
import mybeans.BoardService;

public class ComponentMain {

	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac=
				new AnnotationConfigApplicationContext(MyConf.class);
		
		A a = acac.getBean(A.class);
		System.out.println(a);
		
		B b = acac.getBean(B.class);
		System.out.println(b);
		
		BoardService bs = acac.getBean(BoardService.class);
		System.out.println(bs);
		
		acac.close();
				
	}
}
