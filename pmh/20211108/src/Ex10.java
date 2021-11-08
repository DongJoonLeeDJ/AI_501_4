public class Ex10 {

    public static void main(String[] args) {
        int arr[][] = {
                {11},
                {11, 22},
                {11, 22, 33}
        };
//        sizeof(arr)/sizeof(int)
        System.out.println(arr.length);
        System.out.println(arr[0].length);
        System.out.println(arr[1].length);
        System.out.println(arr[2].length);

        /*
        i = 0 j = 0
        i = 1 j = 0 ~ 1
        i = 2 j = 0 ~ 2
         */

        for( int i =0; i<arr.length ; i++){
            for (int j = 0; j< arr[i].length;j++){
                System.out.print(arr[i][j]+" ");
            }
            System.out.println();
        }
    }
}
