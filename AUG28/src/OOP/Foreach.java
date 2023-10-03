package OOP;

public class Foreach {
    public static void main(String[]args){
        int[]a = {1,2,3,4,5,6};
        int sum = 0;

        for (int x:a){                      //foreach
            System.out.println(x);
            sum += x;
        }
        System.out.println("The Sum is " + sum);
    }
}
