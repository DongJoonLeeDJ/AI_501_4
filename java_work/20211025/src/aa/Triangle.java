package aa;

public class Triangle {
	int base;	// �غ�
	int height;	// ����

//	public Triangle() {} �����Ǿ��� �ִ�. jvm �������ش�..
	
	// ���ڰ��� �ִ� ������ ����� �⺻�����ڴ� ���� �Ұ�.
	public Triangle(int b,int h) {
		base = b;
		height = h;
	}
	
	public double traArea() {
		return (double)base * height / 2;
	}
}
