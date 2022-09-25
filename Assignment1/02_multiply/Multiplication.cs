namespace _02_multiply{
public class Multiplication
{

    public static String MultiplicationTable(int Number){
        String multi = String.Format($"This is the multiplication table of {Number}\n");

        for(int i=0;i<=10;i++){
            multi += String.Format($"{ i,3 } x { Number,3 } = { i*Number,3 }\n");
        }



        return multi;

    }
}
}