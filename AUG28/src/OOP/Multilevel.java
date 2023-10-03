package OOP;
import java.util.Scanner;

class Grandpa {
    int age,year=2023,birthYear;
    Scanner sc = new Scanner(System.in);

    void ageG(){

        System.out.println("Enter Grandpa age : " );
        age=sc.nextInt();
        birthYear = year - age;
        System.out.println("Grandpa Birth Year is " + birthYear);
    }
}

class Father extends Grandpa{

    void ageF(){
        System.out.println("Enter Father age : " );
        age=sc.nextInt();
        birthYear = year - age;
        System.out.println("Father Birth Year is " + birthYear);
    }
}

class Child extends Father {

    void ageC() {
        System.out.println("Enter Child age : ");
        age = sc.nextInt();
        birthYear = year - age;
        System.out.println("Child Birth Year is " + birthYear);
    }
}

public class Multilevel{
    public static void main(String[] args){
        Child c = new Child();
        Father f = new Father();
        c.ageG();
        c.ageF();
        c.ageC();

        f.ageG();
        f.ageF();

    }
}



