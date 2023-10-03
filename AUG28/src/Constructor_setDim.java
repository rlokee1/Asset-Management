class Construct {
    int length; //instance variables
    int breadth;
    int height;

    int Volume() //invoke by object - Static keyword no need
    {
        //int value;
        return length*breadth*height;
        //return value;
    }

    Construct(int l, int b, int h){ //Constructor
        length = l;
        breadth = b;
        height = h;
    }

    void setDim(int l, int b, int h){ //we can also use 'this' pointer,
                                      //Unless compiler automatically set 'this' though we not use 'this' pointer
        length = l;
        breadth = b;
        height = h;
    }
}
public class Constructor_setDim {

    public static void main(String[] args)
    {
        Construct redCube;
        Construct blueCube;
        redCube = new Construct(2,4,5); // It is called only when object creation
        blueCube = new Construct(3,5,5);//No return type

        redCube.setDim(10,20,30); //So, we can change values by using setDim
        blueCube.setDim(5,6,2);

        redCube.Volume();
        blueCube.Volume(); //invoke

        System.out.println("The Volume is " + redCube.Volume());
        System.out.println("The Volume is " + blueCube.Volume()); //invoke by object - Static keyword no need
    }

}