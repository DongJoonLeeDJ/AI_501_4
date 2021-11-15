import java.util.Scanner;

/*
1.
이름(name), 전화번호(tel) 필드와 생성자 등을 가진 Phone 클래스를 작성하고,
실행 예시와 같이 작동하는 PhonBook 클래스를 작성하라.
*/
/*  배열의 크기 ...인원수 >> 3
    이름과 전화번호(이름과 번호는 빈 칸없이 입력)>>황기태 777-7777
    이름과 전화번호(이름과 번호는 빈 칸없이 입력)>>나명품 999-9999
    이름과 전화번호(이름과 번호는 빈 칸없이 입력)>>최자바 333-1234
    저장되었습니다...
    검색할 이름 >>황기순
    황기순이 없습니다.
    검색할 이름 >>최자바
    최자바의 번호는 333-1234 입니다.
    검색할 이름 >>그만
    [Hint] PhoneBook 클래스에서 저장할 사람의 수를 입력받고, Phone 개게 배열을 생성한다.
    한 사람의 정보는 하나의 Phone 객체에 저장한다. 7번 정답을 참고하기 바란다.
    문자열 a와 b가 같은지 비교할 때 a.equals(b)가 참인지로 판단한다.
*/
class Phone{
    private String name;
    private String tel;
    public Phone(String name,String tel) {
        this.name = name;
        this.tel = tel;
    }
    public String getName() {
        return name;
    }
    public String getTel() {
        return tel;
    }
}
// 자바 파일명이랑 클래스명이 동일해야 하는데 public 으로 선언되어져있어서...
public class PhonBook {
    PhonBook(){
        Scanner scan = new Scanner(System.in);

        System.out.print("인원수 >> ");
        int arrsize = scan.nextInt();
        Phone phones[] = new Phone[arrsize];
        //System.out.println("phones.length = "+phones.length);

        scan.nextLine();    // 입력버퍼에 있는 엔터키 지우기..

        for (int i =0; i<arrsize ; i++){
            System.out.print("이름과 전화번호(이름과 번호는 입력)>>");
            String temp = scan.nextLine();
            String name_tel[] = temp.split("\\s");// \\s띄워쓰기 기준 자르기..
//            System.out.println(name_tel[0]);
//            System.out.println(name_tel[1]);
            phones[i] = new Phone(name_tel[0], name_tel[1]);
        }
        System.out.println("저장되었습니다...");
        while(true){
            System.out.println("검색할 이름? ");
            String sel = scan.nextLine();
            if(sel.equals("exit")) {
                System.out.println("종료되었습니다...");
                break;
            }
            int success = 0;
            for(Phone temp : phones){
                if( temp.getName().equals(sel)){
                    System.out.println("검색성공");
                    success = 1;
                    System.out.println(temp.getName());
                    System.out.println(temp.getTel());
                    break;
                }
            }
            if (success == 0){
                System.out.println("검색이 실패하였습니다.");
            }
        }
    }

    public static void main(String[] args) {
        new PhonBook();
    }
}
