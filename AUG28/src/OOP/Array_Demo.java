package OOP;

import java.lang.String;

public class Array_Demo {
    public static void main(String[]args){
        String[] name = new String[5];

        name[0]="Lokesh";
        name[1]="John";
        name[2]="David";
        name[3]="Funk";

        System.out.println(name[1]);

        String[] petname = {"Dog","Cat","Cow","Goat"};
        int len = petname.length;
        System.out.println(petname[2] +'\n'+ "Total array length" +'\t'+ len);
        System.out.println("**********************************************************************************");


        int[][] num =new int[4][];

        num[0]=new int[6];
        num[1]=new int[8];
        num[2]=new int[100];
        num[3]=new int[4];

        int[][] num1={
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}/*3x4 matrix*/
        };

        int[][][] num2=
                {{
                    {1,2,3},/*0,0-->(0,1,2)*/
                    {4,5,6}/*0,1-->(0,1,2)*/
                },/*0th matrix*/
                {
                    {7,8,9},/*1,0-->(0,1,2)*/
                    {10,11,12}
                },/*1st matrix*/
                {
                        {13,14,15},/*2,0-->(0,1,2)*/
                        {16,17,18}
                }
                };/*2nd matrix*/

        System.out.println(num[2][1]);
        System.out.println(num1[2][3]);

        System.out.println(num2[1][0][1]);
        System.out.println(num2[1][0][1]);
    }
}
