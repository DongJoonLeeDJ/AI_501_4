public class LPrinterDriver implements Printable{
    @Override
    public void print(String doc) {
        System.out.println("from LG");
        System.out.println(doc);
    }
}
