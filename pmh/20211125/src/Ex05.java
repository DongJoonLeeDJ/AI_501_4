import java.math.BigInteger;

public class Ex05 {

    public static void main(String[] args) {
        BigInteger bi1 = new BigInteger("1000000000000000");
        BigInteger bi2 = new BigInteger("-999999999999999");

        BigInteger result1 = bi1.add(bi2);
        System.out.println(result1);

        BigInteger result2 = bi1.multiply(bi2);
        System.out.println(result2);
    }
}
