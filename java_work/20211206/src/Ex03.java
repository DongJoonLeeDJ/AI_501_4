

interface HowLong{
    int len(String s);
}

public class Ex03 {

    public static void main(String[] args) {

        HowLong hl =  s-> s.length();
        System.out.println(hl.len("I am so happy"));
    }
}
