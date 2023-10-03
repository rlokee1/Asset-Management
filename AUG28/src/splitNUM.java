import java.util.Scanner;

public class splitNUM {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        long value = sc.nextLong();
        System.out.println("Enter the value " + value);
        long even=0,odd=0,remainder=0,count=0;

        while(value!=0){
            value/=10;
            remainder=value%10;
            if(remainder % 2==0){
                even+=remainder;
            }
            else{
                odd+=remainder;
            }
            ++count;
        }
        System.out.println("The count is " + count);
        System.out.println("The sum of even is" + even);
        System.out.println("The sum of odd is" + odd);
    }
}
