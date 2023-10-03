package OOP;

class Ramesh {
    short a;
    short b;
    int add;
    int prod;
    int diff;
//
//    Ramesh(short a, short b) {
//        this.a=a;
//        //this.b=b;
//        add = a + b;
//        prod=a*b;
//        diff=add-prod;
//        System.out.println("The difference between sum and prod is " + diff);
//    }
//
//
//    public static void main(String[] lokesh) {
//        System.out.println("********* Awakening *********");
//        Ramesh r = new Ramesh((short) 2, (short) 3);
//        System.out.println(r.a);
//        System.out.println(r.b);
//    }
    public static void main(String[] lokesh) {
        Ramesh r = new Ramesh();
        r.a=10;
        r.b=5;
        r.add=r.a+r.b;
        r.prod=r.a* r.b;
        r.diff=r.add-r.prod;
        System.out.println("The Difference between sum prod is " + r.diff);
    }
}
