public class SPrinterDriver implements Printable{
    @Override
    public void print(String doc) {
        System.out.println("from samsung ...");
        System.out.println(doc);
    }
}
