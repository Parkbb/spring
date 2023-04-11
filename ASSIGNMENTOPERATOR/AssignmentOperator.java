public class AssignmentOperator{
    
    public static void main(String[] args){
        //[?] 할당(대입) 연산자: 변수에 특정 값으로 초기화하면 자동 유추에 의해서 형식이 결정됨
        String name = "Java";
        int version = 14;

        System.out.println(name + "," + version);


        int x = 3;
        int y = 3;

        x = x + 2; // 기본형
        y +=2; // 축약형

        System.out.println("x: "+ x + "," + "y : " + y);

        int a = 3;
        int b = 5;

        b += a;
        System.out.println(b); //8

        b -=a;
        System.out.println(b); //5




    }

}