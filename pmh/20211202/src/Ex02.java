/*interface ANIMAL{
    public static final int DOG = 1;
    int CAT = 2;
}
interface PERSON{
    int MAN = 1;
    int WOMAN = 2;
}*/
enum ANIMAL{
    DOG, CAT;
}
enum PERSON{
    MAN, WOMAN;
}
public class Ex02 {
    public static void main(String[] args) {
//        PERSON p1 = PERSON.MAN;
//        System.out.println(p1);
        who(PERSON.MAN);
//        who(ANIMAL.DOG);
    }
    private static void who(PERSON man) {
        switch (man){
            case MAN:
                System.out.println("남성손님입니다.");
                break;
            case WOMAN:
                System.out.println("여성손님입니다.");
                break;
        }
    }
}
