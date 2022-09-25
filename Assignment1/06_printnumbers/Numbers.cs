namespace _06_printnumbers;
public class Numbers
{

    public static String PrintNumber(int num){
        if(num == 1){
            return $"{num}";
        }
        else{
            return $"{num} - {PrintNumber(num - 1)}";
        }
    }

}
