using System;

namespace ExceptionsMyMath
{

    class MyException : FormatException{
        public String Name { get; set; }

        public MyException(String message):base(message)
        {
            
        }
    }

    public class MyMath
    {
        public static void Devide(){
            System.Console.WriteLine("Teller:");
            string t = Console.ReadLine();
            System.Console.WriteLine("Noemer:");
            string n = Console.ReadLine();
            int tint = 0;
            try{
                tint = Int32.Parse(t);
            }
            catch(FormatException e){
                throw new MyException("Not a number"){Name = "Denominator"};
            }
            finally{
                System.Console.WriteLine("This is the finilly");
            }
            int nint = Convert.ToInt32(n);


            System.Console.WriteLine($"{tint}/{nint} = {tint/nint}");

        }
    }
}