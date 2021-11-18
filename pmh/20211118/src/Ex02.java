public class Ex02 {

    public static void main(String[] args) {

        Printable prn1 = new SPrinterDriver();
        prn1.printCMYK("삼성꺼로 출력하도록 하지.... ");

        Printable prn2 = new LPrinterDriver();
        prn2.printCMYK("LG꺼로 출력하도록 하지.... ");

        System.out.println(Printable.PAPER_HEIGHT);
        System.out.println(Printable.PAPER_WIDTH);

//        Printable.PAPER_HEIGHT = 200;

        Printable.staticPrint("출력");
    }

}
