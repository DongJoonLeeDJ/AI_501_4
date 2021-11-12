/*
다음 클래스 각각에 적절한 생성자를 삽입해보자.
물론 상속 관계를 고려하여 각 클래스 별로 필요한 생성자를 삽입해야 한다.
 */
class Car{
    int gasoline;
    Car(int ga){
        this.gasoline = ga;
    }
}
class HybridCar extends Car{
    int electric;
    HybridCar(int ele,int ga){
        super(ga);
        this.electric = ele;
    }
}
class HybridWaterCar extends HybridCar{
    int water;
    // 생성자는 생략 가능하지만 다른생성자 선언시 생략불가
    HybridWaterCar(int water,int ele,int ga) {
        super(ele,ga);
        this.water = water;
    }
    public void showCurrent(){
        System.out.println("잔여 가솔린:"+gasoline);
        System.out.println("잔여 전기:"+electric);
        System.out.println("잔여 물:"+water);
    }
}
public class pa323 {
    public static void main(String[] args) {
        HybridWaterCar hwc = new HybridWaterCar(10,5,3);
        hwc.showCurrent();
    }
}
