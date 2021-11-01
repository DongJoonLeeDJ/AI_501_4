class A{
	public void take() { System.out.println("A ¾à ¹¬À½"); }
}
class B{
	public void take() { System.out.println("B ¾à ¹¬À½"); }	
}
class C{
	public void take() { System.out.println("C ¾à ¹¬À½");	}	
}
public class ABC {
	public void takeA(A a) { a.take(); }
	public void takeB(B b) { b.take(); }
	public void takeC(C c) { c.take(); }
	public void seqtakeABC(A a,B b,C c) {
		a.take();
		b.take();
		c.take();
	}
}
