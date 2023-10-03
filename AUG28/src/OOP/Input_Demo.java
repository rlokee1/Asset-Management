package OOP;

import java.util.Scanner;

public class Input_Demo {
    public static void main(String[]args)
    {

        Scanner sc = new Scanner(System.in);
        System.out.println("Enter any integer: ");
        int a= sc.nextInt();
        System.out.println("The output is :" + '\n' + a);

        if (a>0){
            System.out.println("Given number is positive");
            sc.nextLine();
        }
        else if(a<0){
            System.out.println("Given number is negative");
            sc.nextLine();
        }
        else {
            System.out.println("Given number is Zero");
        }
    }
}
