package OOP;

public class call_BY_value {
    static void add(int b){
        --b;
    }
    public static void main(String[]args){
    int b=5;
    add(b);
    System.out.println(b);
    }
}
