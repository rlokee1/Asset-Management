class Demo {
    int a; //instance variables
    int b;

    int sum() //invoke by object - Static keyword no need
    {
        return a+b;
    }
}
public class sum_NoStatic_withObject {

    public static void main(String[] args)
    {
        Demo obj;
        obj = new Demo();

        obj.a=10;
        obj.b=20;

        obj.sum(); //invoke

        System.out.println("The sum of a + b is " + obj.sum()); //invoke by object - no need for Static keyword
    }

}