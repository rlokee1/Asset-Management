package OOP;

public class For_Divisible {

    public static void main(String[] args) {
        int i;
        System.out.println("Prasanna | Lokesh | Ramajayam");
        System.out.println("Below the numbers 100 to 10000 divisible by both  9 and 10");
        for (i = 100; i <= 10000; i++) {
            if (i % 9 == 0 & i % 10 == 0 )
                System.out.println(i);
        }

        System.out.println("Below the numbers 100 to 10000 divisible only by 9");

        for (i = 100; i <= 10000; i++) {
            if (i % 9 == 0)
                System.out.println(i);
    }

        System.out.println("Below the numbers 100 to 10000 divisible only by 10");

        for (i = 100; i <= 10000; i++) {
            if (i % 10 == 0)
                System.out.println(i);
        }
}
}

