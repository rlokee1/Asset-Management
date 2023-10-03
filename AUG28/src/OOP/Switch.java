package OOP;

import java.util.Scanner;

public class Switch {
    public static void main(String[]args){
        Scanner arun = new Scanner(System.in);
    int a,b;
    System.out.println("Enter the first value :");
    a = arun.nextInt();

    System.out.println("Enter the second value : ");
    b = arun.nextInt();


    char ops;
    System.out.println("Enter the Symbol : ");
    ops=arun.next().charAt(0);

                                                               
        switch (ops){
            case '+':
                System.out.println(a + " + " + b + "=" + (a+b));
                break;
            case '-':
                System.out.println(a + " - " + b + "=" + (a-b));
                break;
            case '*':
                System.out.println(a + " * " + b + "=" + (a*b));
                break;
            case '/':
                System.out.println(a + " / " + b + "=" + (a/b));
                break;
            case '%':
                System.out.println(a + " % " + b + "=" + (a%b));
                break;
            default:
                System.out.println("You Entered Invalid Symbol");
        }
    }
}
