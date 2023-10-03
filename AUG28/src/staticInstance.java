import java.util.Scanner;

public class staticInstance {
    String a;
    static int b;
    public static void main(String[]args){
        Scanner sc = new Scanner(System.in);
        staticInstance s = new staticInstance();
        s.a = sc.nextLine();
        b=sc.nextInt();
        System.out.println("My Favorite food is : " + s.a +" and the count is " + b );
    }
}
