
// ctrl + z 뒤로 가기
// ctrl + y 앞으로가기
// Redo

import java.util.Scanner;

// java 에서는 class 명이랑 파일명이 동일해야 한다는 규칙
// alt + enter 키가 빠른 에러 처리
public class MonthSchedule {
    public static void main(String[] args) {
        Day days[] = new Day[100];
        int index = 0;

        System.out.println("이번달 스케쥴 관리 프로그램.");
        System.out.println("할일(입력:1, 보기:2, 끝내기:3)");
//        day[0] = new Day();
//        day[1] = new Day();
//        System.out.println("day[0] = "+days[0].toString());
//        System.out.println("day[1] = "+days[1].toString());
//        System.out.println("day[2] = "+days[2]);
        Scanner scan = new Scanner(System.in);
        int selectone = scan.nextInt();



//        System.out.println("시작");
//        Day day1 = new Day();
//        day1.setWork("영화보기");
//        day1.show();
    }
}
