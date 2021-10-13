using System;

namespace ExceptionsMyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try{
                MyMath.Devide();
            }
            catch(MyException e){
                System.Console.WriteLine($"{e.Name} {e.Message}");
            }
            catch(DivideByZeroException){
                System.Console.WriteLine($"Cannot Divide by zero");
            }
        }
    }
}
