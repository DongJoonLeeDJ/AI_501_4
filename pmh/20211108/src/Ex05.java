class AA{}
public class Ex05 {
    public static void main(String[] args) {
        int arr[] = new int[5];
        for (int temp : arr){ // java      // for i in arr python
            System.out.println("temp = "+temp);
        }
        System.out.println("arr.length = "+arr.length);

        String sarr[] = new String[5];
        for (String temp : sarr){ // java      // for i in arr python
            System.out.println("temp = "+temp);
        }
        System.out.println("sarr.length = "+sarr.length);

        AA sAA[] = new AA[5];
        for (AA temp: sAA){ // java      // for i in arr python
            System.out.println("temp = "+temp);
        }
        System.out.println("sAA.length = "+sAA.length);
    }
}