
// ctrl + z 뒤로 가기
// ctrl + y 앞으로가기
// Redo

import java.util.Scanner;

// java 에서는 class 명이랑 파일명이 동일해야 한다는 규칙
// alt + enter 키가 빠른 에러 처리
public class MonthSchedule {
    public static void main(String[] args) {
        Day days[] = new Day[30];
        Scanner scan = new Scanner(System.in);
        // 1.work 변수
        // 1.setwork 2.getwork 3.get 4.set 5.show 함수들
        int index = 0;
        while (true) {
            System.out.println("이번달 스케쥴 관리 프로그램.");
            System.out.println("할일(입력:1, 보기:2, 끝내기:3)");
//        day[0] = new Day();
//        day[1] = new Day();
//        System.out.println("day[0] = "+days[0].toString());
//        System.out.println("day[1] = "+days[1].toString());
//        System.out.println("day[2] = "+days[2]);
            int so1 = scan.nextInt();

            System.out.println("so1 = " + so1);
            if (so1 == 1) {
                System.out.println("날짜(1~30)?");
                int so2 = scan.nextInt();   // so2가 1 이면 인덱스 0
                // so2가 30 이면 인덱스 29
                scan.nextLine();    // 입력버퍼에 ... enter키 삭제...
                days[so2 - 1] = new Day();// 인덱스 so2번째에 객체 생성
                System.out.println("할일(빈칸없이입력)?");
                String so3 = scan.nextLine();
                days[so2 - 1].setWork(so3);
                System.out.println("입력이 정상적으로 되었습니다.");
            } else if (so1 == 2) {
                for (int i = 0; i < 30; i++) {
                    if (days[i] != null) {
                        System.out.println(i+"번쨰 "+days[i]);
                    }
                }
            } else if (so1 == 3) {
                System.out.println("종료됩니다.");
                break;
            }
        }

//        System.out.println("시작");
//        Day day1 = new Day();
//        day1.setWork("영화보기");
//        day1.show();
    }
}
