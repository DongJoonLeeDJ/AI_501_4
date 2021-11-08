
class Data{
    public void doA(int a){
        System.out.println("Doa = "+ a);
    }
}
// ocjp
public class Ex07 {
    public static void main(String[] args) {
        /*
        System.out.println("java.length = "+"java".length());
        String[] sr = new String[7];
        sr[0] = new String("Java");
        sr[1] = new String("System");
        sr[2] = new String("Complier");
        sr[3] = new String("Park");
        sr[4] = new String("Tree");
        sr[5] = new String("Dinner");
        sr[6] = new String("Brunch Cafe");

        int cnum = 0;
        for(String temp : sr){
            cnum += temp.length();
        }
        System.out.println("cnum = "+ cnum);
        String ar[] = new String[1];
        System.out.println(ar[0].length());
*/
        Data datas[] = new Data[2];

        datas[0] = new Data();

        datas[0].doA(0);
        datas[1].doA(1);
    }
}
