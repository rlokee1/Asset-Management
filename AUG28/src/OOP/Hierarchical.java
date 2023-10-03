package OOP;

class Hierarchical {
    public static void main(String[]args){
        Aqua Aq;                            /*DYNAMIC BINDING*/
        Aq = new Aqua();
        Aq.show();
        Aq = new Shark();
        Aq.show();
        Aq= new Whale();
        Aq.show();
        Aq= new Dolphin();
        Aq.show();
    }
}

class Aqua{
    void show(){
        System.out.println("I'm Aqua");
}
}

class Shark extends Aqua{
    void show(){
        System.out.println("I'm Shark");
    }
}

class Whale extends Aqua{
    void show(){
        System.out.println("I'm Whale");
    }
}

class Dolphin extends Aqua{
    void show(){
        System.out.println("I'm Dolphin");
    }
}