
public class Ex03 {

    public static void main(String[] args) {
        showAll("Box");
        showAll("Box","Toy");
        showAll("Box","Toy","Robot");
        
    }

    private static void showAll(String...vargs ) {
        for(String temp:vargs){
            System.out.println(temp);
        }
        System.out.println();
    }
}
