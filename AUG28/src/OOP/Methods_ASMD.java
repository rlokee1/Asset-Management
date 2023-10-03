package OOP;

public class Methods_ASMD {
    public void Add(){
        int a=10,b=5;
        System.out.println(a+b);
    }
    public void Subtract(int a,int b){
        System.out.println(a-b);
    }
    public int Multiply(){
        int a=10,b=5,c=a*b;
        System.out.println(c);
        return c;
    }
    public int Divide(int a,int b){
        int c=a/b;
        System.out .println(a/b);
        return c;
    }
    public static void main(String[]args){
        Methods_ASMD l = new Methods_ASMD();
        l.Add();
        l.Subtract(10,5);
        l.Multiply();
        l.Divide(10,5);
        
    }


}
