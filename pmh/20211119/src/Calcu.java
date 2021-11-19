public class Calcu {
    int a;
    int b;
    public void setValue(int a , int b ){
        this.a = a;
        this.b = b;
    }
    public void calculate(){}
}
class Add extends Calcu{
    @Override
    public void calculate() {
        System.out.println(a+"+"+b+" = "+(a+b));
    }
}
class Sub extends Calcu{
    @Override
    public void calculate() {
        System.out.println("a-b = "+(a-b));
    }
}
class Mul extends Calcu{
    @Override
    public void calculate() {
        System.out.println("a*b = "+(a*b));
    }
}
class Div extends Calcu{
    @Override
    public void calculate() {
        System.out.println("a/b = "+(a/b));
    }
}
