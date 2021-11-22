import java.util.Scanner;
class Seat{
    String line; // S,A,B
    String r_name;  // 예약자명..
    Seat(String line, String r_name){
        this.line = line;
        this.r_name = r_name;
    }
}
public class Ex01 {
    Ex01(){
        Seat seats[] = new Seat[30];
        for (int i = 0; i< seats.length; i++)
        {
            if( i < 10)
                seats[i] = new Seat("S","__");
            else if( i< 20)
                seats[i] = new Seat("A","__");
            else if( i< 30)
                seats[i] = new Seat("B","__");
        }

        Scanner scan = new Scanner(System.in);
        while(true) {
            System.out.println("\n예약,조회,취소,끝내기");
            String select = scan.nextLine();
            if (select.equals("예약")) {
                System.out.println("좌석구분 S(1), A(2), B(3)>> ");
                int seatline = scan.nextInt();  // S=1 , S=2, S=3
                scan.nextLine(); //입력버퍼지우기
                if(seatline ==1)
                    System.out.print(" >> S ");
                if(seatline ==2)
                    System.out.print(" >> A ");
                if(seatline ==3)
                    System.out.print(" >> B ");
                for (int i = (seatline -1) *10; i< ((seatline -1) *10)+10; i++)
                    // i = 0~9, 10~19, 20~29
                {
                    System.out.print(seats[i].r_name+" ");
                }
                System.out.print("\n이름>> ");
                String name = scan.nextLine();
                System.out.print("번호>> ");
                int bunho = scan.nextInt();
                scan.nextLine(); //입력버퍼지우기

                seats[bunho-1].r_name = name;

            } else if (select.equals("조회")) {
                System.out.println("S >> ");
                for (int i = 0; i< 10; i++)
                {
                    System.out.print(seats[i].r_name+" ");
                }
                System.out.println("\nA >> ");
                for (int i = 10; i< 20; i++)
                {
                    System.out.print(seats[i].r_name+" ");
                }
                System.out.println("\nB >> ");
                for (int i = 20; i< 30; i++)
                {
                    System.out.print(seats[i].r_name+" ");
                }
            } else if (select.equals("취소")) {
                System.out.println("취소");
            } else if (select.equals("끝내기")) {
                System.out.println("종료합니다.");
                break;
            }
        }
    }
    public static void main(String[] args) {
        new Ex01();
    }
}
