package Constructor360;

public class thisKeyword {
    thisKeyword(String d, String e, String f, String g ){
        System.out.println("My Atti Friends - " + d + e + f+g);
    }
    thisKeyword(String a){
        this("Malik","Baasha");
        System.out.println("My School Friend - " + a + "Michael" + "Lucifer");
    }
    thisKeyword(String b,String c){
        this("Senthil","Guna","Velan", "Rajan");
        System.out.println("My College Friend - " + b + c);
    }

    public static void main(String[]args){
        thisKeyword t = new thisKeyword("Anwar");
    }
}
