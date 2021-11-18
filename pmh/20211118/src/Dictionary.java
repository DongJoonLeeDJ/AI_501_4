import java.util.Scanner;

/*
다음과 같은 Dictionary 클래스가 있다. 실행 결과와 같이 작동하도록
        Dictionary 클래스의 kor2Eng() 메소드와 DicApp 클래스를 작성하라.
 */
public class Dictionary {
    private static String[] kor = {"사랑", "아기", "돈", "미래", "희망"};
    private static String[] eng = {"love", "baby", "money", "future", "hope"};

    public static String kor2Eng(String word) {
        for (int i = 0; i < kor.length; i++) {
            if (kor[i].equals(word))
                return kor[i] + "는(은)" + eng[i] + "입니다";
        }
        return word + "는(은) 사전에 없습니다";
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        while (true) {
            System.out.println("한영 단어 검색 프로그램입니다.");
            System.out.println("한글 단어? ");
            String word = scan.nextLine();
            System.out.println("word = " + word);
            if (word.equals("그만"))
                break;
            String result = kor2Eng(word);
            System.out.println(result);
        }

    }
}
/*
    한영 단어 검색 프로그램입니다.
        한글 단어?희망
        희망은 hope
        한글 단어?아가
        아가는 저의 사전에 없습니다.
        한글 단어?아기
        아기는 baby
        한글 단어?그만
 */