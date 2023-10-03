package OOP;

import java.util.Scanner;

public class Book_Purchase {
    public static void main(String[]args) {
        Scanner sc = new Scanner(System.in);
        a:
        while (true) {
            String[] bookName = {"1. Bhagavat geetha", "2. Bible", "3. Quaran", "4. Science Book", "5. Maths Book"};
            System.out.println("Available Books : ");

            for (String x : bookName) {
                System.out.println(x);
            }

            int option;
            System.out.println("Enter the Book serial number from 1 to 5 to know the details : " + '\n');
            option = sc.nextInt();
            sc.nextLine();

            switch (option) {
                case 1:
                        int costGeetha = 150;
                        System.out.println("Bhagavat Geetha" + '\n' + "Available Stock : 100" + '\n' + "price : Rs." + costGeetha + "/-");

                        System.out.println("How many books do you need : ");
                        int countGeetha = sc.nextInt();
                        int totalAmount1 = costGeetha * countGeetha;
                        System.out.println("Total no.of books ordered: " + countGeetha + '\n' + "and total amount is Rs." + totalAmount1);

                            System.out.println('\n' + "Please confirm your order type --> '1' ");
                            System.out.println('\n' + "If you need to cancel order type --> '0' ");
                            int order1 = sc.nextInt();

                            sc.nextLine();
                            if (order1 == 1) {
                                System.out.println("Your order was confirmed sucessfully and the delivery will reach you soon");
                                System.out.println('\n' + "Please enter any number above zero to continue purchase : ");
                                System.out.println('\n' + "Please enter the number 0 to exit: ");
                                int morePurchase = sc.nextInt();
                                sc.nextLine();
                                if (morePurchase > 0)
                                    break;
                                else if (morePurchase == 0)
                                    break a;
                            }
                            else if (order1 == 0) {
                                System.out.println("Your order was cancelled successfully");
                                break;
                            } else
                            {
                                System.out.println("Invalid Number. Enter the number either 0 or 1" +'\n');}


                        break;

                case 2:
                    int costBible = 200;
                    System.out.println("Bhagavat Geetha" + '\n' + "Available Stock : 100" + '\n' + "price : Rs." + costBible + "/-");

                    System.out.println("How many books do you need : ");
                    int count2 = sc.nextInt();
                    int totalAmount2 = costBible * count2;
                    System.out.println("Total no.of books ordered: " + count2 + '\n' + "and total amount is Rs." + totalAmount2);

                    System.out.println('\n' + "Please confirm your order type --> '1' ");
                    System.out.println('\n' + "If you need to cancel order type --> '0' ");
                    int order2 = sc.nextInt();

                    sc.nextLine();
                    if (order2 == 1) {
                        System.out.println("Your order was confirmed sucessfully and the delivery will reach you soon");
                        System.out.println('\n' + "Please enter any number above zero to continue purchase : ");
                        System.out.println('\n' + "Please enter the number 0 to exit: ");
                        int morePurchase = sc.nextInt();
                        sc.nextLine();
                        if (morePurchase > 0)
                            break;
                        else if (morePurchase == 0)
                            break a;
                    }
                    else if (order2 == 0) {
                        System.out.println("Your order was cancelled successfully");
                        break;
                    } else
                    {
                        System.out.println("Invalid Number. Enter the number either 0 or 1" +'\n');}

                    break;
                case 3:
                    System.out.println("Quaran" + '\n' + "Available Stock : 120" + '\n' + "price : Rs:230/-");
                    break;
                case 4:
                    System.out.println("Science Book" + '\n' + "Available Stock : 140" + '\n' + "price : Rs:120/-");
                    break;
                case 5:
                    System.out.println("Maths Book" + '\n' + "Available Stock : 170" + '\n' + "price : Rs:140/-");
                    break;
                default:
                    System.out.println('\n' + "Invalid Number. Please Enter the number from 1 to 5");
            }
        }
    }
}
