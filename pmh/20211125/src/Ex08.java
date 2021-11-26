import java.util.Arrays;

public class Ex08 {

    public static void main(String[] args) {
        // 객체 변수.. 배열 변수.. 참조변수...
        double[] arOrg = {1.1, 2.2, 3.3, 4.4, 5.5};

//        double[] arcpy1 = arOrg;
        double[] arcpy1 = Arrays.copyOf(arOrg, arOrg.length);
        
        
        if ( arOrg == arcpy1){
            System.out.println(" == 같다");
        }
        else{
            System.out.println(" == 다르다");
        }

        if(Arrays.equals(arOrg,arcpy1)){
            System.out.println(" Arrays.equals 같다");
        }
        else{
            System.out.println("Arrays.equals 다르다");
        }
//        arcpy1[0] = 3.3;

//        for( double elem : arOrg){
//            System.out.print(elem+"\t");
//        }
//        System.out.println();
//
//        for( double elem : arcpy1){
//            System.out.print(elem+"\t");
//        }
//        System.out.println();
    }
}
