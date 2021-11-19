import java.io.File;
import java.util.Scanner;

public class Ex05 {

    public static void main(String[] args) {
        Scanner scan = null;
        try{
            scan = new Scanner(new File("a.txt"));
            String line = scan.nextLine();
            System.out.println("line = "+line);
            line = scan.nextLine();
            System.out.println("line = "+line);
            line = scan.nextLine();
            System.out.println("line = "+line);
            line = scan.nextLine();
            System.out.println("line = "+line);
        }catch (Exception e){
            System.out.println(e.getMessage());
            System.out.println("예외");
        }
        finally {
            System.out.println("파이날");
            scan.close();
        }
    }
}
