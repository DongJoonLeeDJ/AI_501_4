import aa.Triangle;

/*
 * Ex01 -> Exam
 * Ex02 -> Exam
 * 
 * Ex03 -> Triangle
 * 
 * 밑변과 높이 정보를 저장하고
 * 밑변과 높이를 변경하는 생성자메서드
 * 삼각형넓이를 구하는 메서드
 */
public class Ex03 {
	
	public static void main(String[] args) {
		Triangle t1 = new Triangle(5, 3);
		double result = t1.traArea();
		System.out.println("넓이 = "+result);
	}

}
