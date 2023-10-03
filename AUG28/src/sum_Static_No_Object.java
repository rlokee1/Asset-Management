public class sum_Static_No_Object {
    /*
     * Methods - carries out a specific task
     * Method input - parameters/arguments
     */
    static int sum(int a, int b) /* Method Definition //int : we should mention any return
                                type as int, void, bool, etc.,*/
    {
        int sum = a+b;
//        sum = a + b;
        return sum;
    }

    static void printLine(){
        System.out.println("*********************************************");
    }
    public static void main(String[] args)
    {
        printLine();
        System.out.println("Main Method statements always executes first"); //println is In-built method call

        System.out.println("The Sum of a + b  = " + sum(2,7)); // Passing arguments
        System.out.println("The Sum of a + b  = " + sum(3,4));
        System.out.println("The Sum of a + b  = " + sum(9,44));

        printLine();

        /*int value = sum(7,4);
        System.out.println("The Sum of a + b  = " + value);*/

    }
}
