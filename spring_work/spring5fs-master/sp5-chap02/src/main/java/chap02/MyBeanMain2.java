package chap02;

import org.springframework.context.support.GenericXmlApplicationContext;

public class MyBeanMain2 {

	public static void main(String[] args) {
		
		GenericXmlApplicationContext gxac = 
				new GenericXmlApplicationContext("./chap02/mybeanfactory.xml");
		
		BB bb = gxac.getBean(BB.class);
		bb.doB();
		BB bb2 = gxac.getBean(BB.class);
		
		System.out.println("bb==bb2 = "+(bb==bb2));
		gxac.close();
		
		// java -> groovy? 코틀린? 변화...
		// oracle - 구글사
		// 버전... 8거의.. 2~3년...1~2 8-> 17..???
		// 코틀린... 구글... 밀고.. 구글api... 음성.. 지도..
		
		
	}
}
