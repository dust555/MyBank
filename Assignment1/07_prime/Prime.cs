namespace _07_prime;
public class Prime
{

    static Boolean IsDiv(int num, int quot){
        
        if(quot == 1){
            return false;
        }
        else if(num % quot == 0){
            return true;
        }
        else{
            return IsDiv(num, quot-1);
        }
    }

    public static Boolean IsPrime(int num){
        return !IsDiv(num,num-1);
    }
}
