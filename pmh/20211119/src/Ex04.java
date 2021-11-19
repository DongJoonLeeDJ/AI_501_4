
class MyException extends Exception{
    MyException(){
        super("나만의 예외.....");
    }
}

public class Ex04 {
    public static void main(String[] args) throws MyException {
        // a값이 30이상이면 예외가 발생해야됨..
        int a = 30;

        if (a >=30)
            throw new MyException();

    }
}
