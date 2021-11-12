public class CheeseCake extends Cake {
    @Override
    public void yummy(){
        super.yummy();
        System.out.println("Yummy CheeseCake");
    }
    public static void main(String[] args) {
        Cake c1 = new CheeseCake();
        CheeseCake c2 = new CheeseCake();

        c1.yummy();
        c2.yummy();

    }
}
