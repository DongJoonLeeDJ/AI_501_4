import aa.Triangle;

/*
 * Ex01 -> Exam
 * Ex02 -> Exam
 * 
 * Ex03 -> Triangle
 * 
 * �غ��� ���� ������ �����ϰ�
 * �غ��� ���̸� �����ϴ� �����ڸ޼���
 * �ﰢ�����̸� ���ϴ� �޼���
 */
public class Ex03 {
	
	public static void main(String[] args) {
		Triangle t1 = new Triangle(5, 3);
		double result = t1.traArea();
		System.out.println("���� = "+result);
	}

}
