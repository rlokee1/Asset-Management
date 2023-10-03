package OOP;

import java.util.Scanner;

public class Break_Continue {
    public  static void main(String[]args){
        a:
        while(true){
        Scanner sc = new Scanner(System.in);

        String[] bookName = {"1. Bhagavat geetha", "2. Bible", "3. Quaran", "4. Science Book", "5. Maths Book"};
        System.out.println("Available Books : ");

        for (String x : bookName) {
            System.out.println(x);
        }

        int option;
        System.out.println("Enter the Book serial number from 1 to 5 to know the details : " + '\n');
        option = sc.nextInt();
        sc.nextLine();

        b:
        while(true)
        {
            switch (option) {
                case 1:
                    int cost_BGeetha = 150;
                    System.out.println("Bhagavat Geetha" + '\n' + "Available Stock : 100" + '\n' + "price : Rs." + cost_BGeetha + "/-");

                    System.out.println("How many books do you need : ");
                    int count1 = sc.nextInt();
                    int totalAmount1 = cost_BGeetha * count1;
                    System.out.println("Total no.of books ordered: " + count1 + '\n' + "and total amount is Rs." + totalAmount1);

                    System.out.println('\n' + "Please confirm your order type --> '1' ");
                    System.out.println('\n' + "If you need to cancel order type --> '0' ");
                    int order_BGeetha = sc.nextInt();
                    if (order_BGeetha == 1)
                        System.out.println("Your order was confirmed sucessfully");
                    else if (order_BGeetha == 0)
                        System.out.println("Your order was cancelled sucessfully");
                    else
                        System.out.println("Please type either '1' to confirm and '0' to cancel order");

                    System.out.println('\n' + "Please enter any number above zero to continue purchase -->");
                    System.out.println('\n' + "Please enter the number 0(zero) to exit --> ");
                    int continuePurchase1 = sc.nextInt();
                    if (continuePurchase1 > 0)
                        break b;
                    else if (continuePurchase1 == 0)
                        break a;
                    else
                        System.out.println("Please type either '1' to confirm and '0' to cancel order");

                    break;

                case 2:
                    int costBible = 200;
                    System.out.println("Bible" + '\n' + "Available Stock : 200" + '\n' + "price : Rs." + costBible + "/-");

                    System.out.println("How many books do you need : ");
                    int count2 = sc.nextInt();
                    int totalAmount2 = costBible * count2;
                    System.out.println("Total no.of books ordered: " + count2 + '\n' + "and total amount is Rs." + totalAmount2);

                    System.out.println('\n' + "Please confirm your order type --> '1' ");
                    System.out.println('\n' + "If you need to cancel order type --> '0' ");
                    int orderBible = sc.nextInt();
                    if (orderBible > 0)
                        System.out.println("Your order was confirmed sucessfully");
                    else if (orderBible == 0)
                        System.out.println("Your order was cancelled sucessfully");
                    else
                        System.out.println("Please type either '1' to confirm and '0' to cancel order");

                    System.out.println('\n' + "Please enter any number above zero to continue purchase -->");
                    System.out.println('\n' + "Please enter the number 0(zero) to exit --> ");
                    int continuePurchase2 = sc.nextInt();
                    if (continuePurchase2 > 0)
                        break b;
                    else if (continuePurchase2 == 0)
                        break a;
                    else
                        System.out.println("Please type either '1' to confirm and '0' to cancel order");

                    break;

                case 3:

                    int costQuaran = 200;
                    System.out.println("Bible" + '\n' + "Available Stock : 200" + '\n' + "price : Rs." + costQuaran + "/-");

                    System.out.println("How many books do you need : ");
                    int count3 = sc.nextInt();
                    int totalAmount3 = costQuaran * count3;
                    System.out.println("Total no.of books ordered: " + count3 + '\n' + "and total amount is Rs." + totalAmount3);

                    System.out.println('\n' + "Please confirm your order type --> '1' ");
                    System.out.println('\n' + "If you need to cancel order type --> '0' ");
                    int orderQuaran = sc.nextInt();
                    if (orderQuaran > 0)
                        System.out.println("Your order was confirmed sucessfully");
                    else if (orderQuaran == 0)
                        System.out.println("Your order was cancelled sucessfully");
                    else
                        System.out.println("Please type either '1' to confirm and '0' to cancel order");

                    System.out.println('\n' + "Please enter any number above zero to continue purchase -->");
                    System.out.println('\n' + "Please enter the number 0(zero) to exit --> ");
                    int continuePurchase3 = sc.nextInt();
                    if (continuePurchase3 > 0)
                        break b;
                    else if (continuePurchase3 == 0)
                        break a;
                    else
                        System.out.println("Please type either '1' to confirm and '0' to cancel order");

                    break;

            }
        }
    }
}
}
