public class StaticEx {

    public static void main(String[] args) {
        int[] array1 = {1, 5, 7, 9};
        int[] array2 = {3, 6, -1, 100, 77};
        ArrayUtil au = new ArrayUtil();
        int[] array3 = au.concat(array1, array2);
        au.print(array3);
    }

}
