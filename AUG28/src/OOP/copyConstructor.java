package OOP;

public class copyConstructor {
    int m;
    String n;
    copyConstructor(int a,String b){
       m=a;
       n=b;
    }
    copyConstructor(copyConstructor s){
        m = s.m;
        n = s.n;
        System.out.println(m +""+ n);
    }
    void show(){
        System.out.println(m + " " + n);
    }
    public static void main(String[] args){
        copyConstructor c = new copyConstructor(4,"Me");
        copyConstructor c1 = new copyConstructor(c);
        c1.show();

    }
}
