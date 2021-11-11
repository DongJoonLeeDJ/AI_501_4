/*
문제 2
다음형태로 표현된 2차원 배열이 존재한다고 가정해보자

1 2 3 1행
4 5 6 2행
7 8 9 3행

이러한 형태를 갖는 int형 2차원 배열이 인자로 전달되면,
다음의 형태로 배열의 구조를 변경시키는 메소드를 정의하자

7 8 9 3행이 1행으로
1 2 3 1행이 2행으로
4 5 6 2행이 3행으로

물론 배열의 가로와 세로 길이에 상관없이 위와 깉이 동작하도록 메소드를
정의해야한다.
 */
public class Chap13_2 {
    public static void main(String[] args) {
        System.out.println("변경전");
        int arr[][] = {{1,2,3},{4,5,6},{7,8,9}};
        for( int i =0; i< arr.length;i++){
            for (int j = 0; j<arr[i].length;j++){
                System.out.print(arr[i][j]+" ");
            }
            System.out.println();
        }
        charr(arr);
        System.out.println("변경후");
        for( int i =0; i< arr.length;i++){
            for (int j = 0; j<arr[i].length;j++){
                System.out.print(arr[i][j]+" ");
            }
            System.out.println();
        }
    }
    private static void charr(int[][] arr) {
        int brr[] = arr[0]; // brr은 0번째행을 가지고있다.
//        for(int b : brr) System.out.println("b ="+b);
        arr[0] = arr[2];
        arr[2] = brr;

        brr = arr[2];
        arr[2] = arr[1];
        arr[1] = brr;
    }
}










