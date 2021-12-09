import java.util.Optional;

public class Ex02 {

    public static void main(String[] args) {
        Friend f1 = new Friend("홍길동",null); // 회사 안다님
        Friend f2 = new Friend("김길동",Optional.of(new Company("에이SW")));

//        if ( f1.cmp != null)
//            System.out.println(f1.cmp.getcName());
//        else
//            System.out.println("회사 안다님");

//        System.out.println(f2.cmp.getcName());

        Optional<Friend> os1 = Optional.of(new Friend("홍길동",null));

        String cname = os1
                        .map(friend -> friend.getCmp())
                        .map(company -> company.get().getcName())
                        .orElse("회사안다님");

        System.out.println(cname);

    }
}
