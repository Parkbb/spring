public class SwapDemo{


    public static void main(String[] args){
        int i = 100;
        int j = 200;

        System.out.println("처음: " + i + "," + j);

        //변숫값 서로 바꾸기
        int temp = i;
        i = j;
        j = temp;
        
        System.out.println("처음: " + i + "," + j);



    }
}