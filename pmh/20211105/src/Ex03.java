public class Ex03 {

    public static void main(String[] args) {
        double e = 3.1415;
        String f = "3";
        // 문자열 변환 두가지 방법

        // 1. String.valueof 함수 사용
        String a = String.valueOf(e);

        // 2 문자열 더하면 자동으로 문자열로 형변환..
        String b = e + "";

        System.out.println("a = "+a);
        System.out.println("b = "+b);
        // 3. String 을 int형변환
        String ar[]="3.1415".split("\\.");
        System.out.println(ar[0]);
        System.out.println(ar[1]);

        int c = Integer.parseInt("3.1415".split("\\.")[0]);
        // 4. String 을 double형변환
        double d = Double.parseDouble(a);
        System.out.println("c = "+c);
        System.out.println("d = "+d);
    }

}










