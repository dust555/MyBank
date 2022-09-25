namespace _09_fizzbuzz;
public class FizzBuzz
{

    static String CheckNumber(String three, String five, int num){
        if(num % 3 != 0 && num % 5 != 0){
            return num.ToString() + " ";
        }
        String ret = "";
        if(num % 3 == 0)
            ret += three;
        if(num % 5 == 0)
            ret += five;

        return ret + " ";
    }

    public static String Run(){
        return Run("Fizz", "Buzz", 100);
    }

    public static String Run(int end){
        return Run("Fizz", "Buzz", end);
    }

    public static String Run(String three, String five, int end){
        String ret = "";
        for(int i=1; i<=end;i++){
            ret += CheckNumber(three,five,i);
            if(i % 10 == 0)
                ret += "\n";

        }
        return ret;
    }

}
