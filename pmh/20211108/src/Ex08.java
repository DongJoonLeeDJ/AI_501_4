public class Ex08 {
    public static void main(String[] args) {
        int arr[] = {1,2,3,4};
        int brr[] = arr;

        brr[0] = 10;
        for(int a : arr){
            System.out.println("a = "+a);
        }
        for(int b : brr){
            System.out.println("b = "+b);
        }

    }
}
