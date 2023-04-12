import javax.swing.text.html.MinimalHTMLWriter;

public class PostfuxOperator {
    public static void main(String[] args) {
        
        int x = 3;
        int y = x++;
        System.out.println(y); //3
        System.out.println(x); //4
    }
}
