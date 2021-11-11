/*
문제1
다음 메소드는 int형 1차원 배열에 저장된 값을
두번쨰 매개변수로 전달된 값의 크기만큼 전부 증가 시킨다
public static void addOneDArr(int[] arr, int add){
    for(int i =0; i<arr.length; i++)
        arr[o] +=add;
}
위 메소드를 호출하는 형태로, int형 2차원 배열에 저장된 값 전부를
두번째 매개변수로 전달된 값의 크기만큼 증가시키는 메소드를
다음의 형태로 정의하자
public static void addTwoDArr(int[][] arr), int add){
    // 이안에서 addOneDarr 메소드를 호출한다.
}
*/

public class Chap13_1 {
    // 1차원 배열을 파라매터로 받고 add 만큼 증가 시키는 함수
    public static void addOneDArr(int[] arr, int add) {
        for (int i = 0; i < arr.length; i++)
            //14 = 10+4
            // 9 = 5 + 4
            // 6 = 2 + 4
            arr[i] = arr[i] +  add;
    }
    public static void addTwoDArr(int[][] arr, int add) {
        for (int temp_arr[] : arr) {
            // {10 ,5 ,2}
            // {1,2,3,4}
            addOneDArr(temp_arr,add);
        }
    }
    public static void main(String[] args) {
/*        int arr[] = {10, 5, 3 , 2, 7};
            addOneDArr(arr,add);
 */
        int darr[][] = {{10,5,2},{1,2,3,4},{6,7,8,9,10}};
        int add = 4;

        for (int temp_arr[] : darr) {
            for ( int temp: temp_arr)
                System.out.println("temp = "+ temp);
            System.out.println();
        }
        addTwoDArr(darr,add);
        System.out.println("변경후");
        for (int temp_arr[] : darr) {
            for ( int temp: temp_arr)
                System.out.println("temp = "+ temp);
            System.out.println();
        }
    }

}