package OOP.Polymorphism;

class parent {
    parent(int k,String s) {
        System.out.println("Parent Constructor");
    }
}
class child extends parent{
        child(){
            super(6,"kol");
            System.out.println("Child Constructor");
        }
}


class Overriding_Constructor {
    public static void main(String[] args) {
            new child();
    }
}