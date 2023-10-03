package OOP;

public class Stack {
    int s[] = new int[10];
    int tos;

    Stack() {
        tos = -1;
    }

    void push(int item) {
        if(tos==s.length)
            System.out.println("Stack is full");
        else
            //tos=tos+1;
            //s[tos]=item;
            s[++tos] = item;
    }

    int pop(){
        if(tos>=0)
            return s[tos--];
        else {
            System.out.println("Stack is empty");
            return -1;
        }
    }

}
