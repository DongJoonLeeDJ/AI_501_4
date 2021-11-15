public class Ex02 {
    public static void main(String[] args) {
        Friend f1 = new CmpFriend("aaa","111-1111","개발팀");
        Friend f2 = new UniFriend("bbb","222-2222","IT");

        f1.showInfo();
        f2.showInfo();

        Friend frs[] = new Friend[10];
        int frs_cnt = 0;
        frs[frs_cnt++] = new CmpFriend("aaa","111-1111","개발팀");
        frs[frs_cnt++] = new UniFriend("bbb","222-2222","IT");
        frs[frs_cnt++] = new CmpFriend("ccc","333-3333","디자인팀");
        frs[frs_cnt++] = new UniFriend("ddd","444-4444","서버");
        frs[frs_cnt++] = new CmpFriend("eee","555-5555","퍼블리셔팀");
        frs[frs_cnt++] = new UniFriend("fff","666-6666","인터넷");

        System.out.println("frs_cnt = "+frs_cnt);

        for (Friend fr : frs){
            fr.showInfo();
        }


//        frs[1].showInfo();
//        frs[2].showInfo();


    }
}
