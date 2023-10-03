package OOP.Polymorphism;

class Avenger{

    void save(){
        int number = 10;
        System.out.println("Avengers Assemble");
        //return number;
    }
}
class ironMan extends Avenger{
    void save(){
        super.save();
        System.out.println("I'm Iron Man");
    }
}

class captainAmerica extends ironMan{
    void save(){
        super.save();
        System.out.println("I'm Captain America");
    }
}

class Hulk extends captainAmerica{
    void save(){
        super.save();
        System.out.println("I'm Hulk");
    }
}
public class Overriding {
static void num(Avenger a){
   // System.out.println(a.number);
    }

public static void main(String[]args){
        Hulk h = new Hulk();
        h.save();
    }
}
