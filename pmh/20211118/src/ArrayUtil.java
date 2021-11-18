/*2.
    다음 2개의 static 가진 ArrayUtil 클래스를 만들어보자.
    다음 코드의 실행 결과를 참고하여
    concat()와 print()를 작성하여 ArrayUtil 클래스를 완성하라.

    python
    [1,2,3,4,5] + [6,7,8,9,10]
    java
    concat
    [1,2,3,4,5] + [6,7,8,9,10]
*/
public class ArrayUtil {
    public int[] concat(int[] a, int[] b) {
        int temp[] = new int[a.length+b.length];
        int index = 0;
        for (int atemp : a) {
            temp[index] = atemp;
            index += 1;
        }
        for (int btemp : b)
            temp[index++] = btemp;
        return temp;
    }
    public void print(int[] a) {
        System.out.print("[ ");
        for (int temp : a)
            System.out.print(temp+" ");
        System.out.print(" ]");

    }
}

/*
[ 1  5  7  9  3  6  -1  100  77 ]
*/
