package OOP;

public class ObjectCreate_ASMD {
    static int a=10,b=5;
        public static void Add(){

            System.out.println(a+b);
        }
        public static void Subtract(int a,int b){

            System.out.println(a-b);
        }
        public static int Multiply(){
            int c=a*b;
            return c;
        }
        public static int Divide(int a,int b){
            int c=a/b;
            return c;
        }
        public static void main(String[]args){
           // OOP.Methods_ASMD l = new OOP.Methods_ASMD();
           // Constructor_ASMD l = new Constructor_ASMD();
            Add();
            Subtract(10,5);
            System.out.println(Multiply());
            System.out.println(Divide(10,5));
        }
    }

