public class initialStar {
    public static void main(String[]args){
        for(int i=0;i<=5;i++) {
                System.out.print("* ");
        }
        System.out.println("");
        for(int i=0;i<=6;i++) {
            if(i<=2)
            {
                System.out.println("*         *");
            }
        }
                System.out.println("* * * * * *");

        for (int k=0;k<=5;k++){
            if(k==1)
                System.out.println("* *" );
            else if (k==2)
                System.out.println("*   *");
            else if (k==3)
                System.out.println("*     *");
            else if (k==4)
                System.out.println("*       *");
            else if (k==5)
                System.out.println("*         *");
    }
}
}
