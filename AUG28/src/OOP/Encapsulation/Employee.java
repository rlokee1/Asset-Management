package OOP.Encapsulation;

public class Employee {

    private String name;
    private int age;
    private float salary;

    public void SetName(String a) {
        name = a;
    }

    public void setAge(int b) {
        age = b;
    }

    public void setSalary(float c) {
        salary = c;
    }

    public void setName(String name) {
        String a = name;
    }
}