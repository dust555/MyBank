using _01_person;
using _02_multiply;
using _03_operations;
using _04_longestword;
using _05_stringlength;
using _06_printnumbers;
using _07_prime;
using _08_rectangle;
using _09_fizzbuzz;

while (true){

    Console.WriteLine("Choose an option");
    Console.WriteLine("1: Person hello");
    Console.WriteLine("2: Multiplication Table");
    Console.WriteLine("3: Operations");
    Console.WriteLine("4: Longest Word");
    Console.WriteLine("5: String Length");
    Console.WriteLine("6: Print Numbers");
    Console.WriteLine("7: Prime Number?");
    Console.WriteLine("8: Rectangle");
    Console.WriteLine("9: FizzBuzz");
    Console.WriteLine("");
    Console.WriteLine("0: EXIT");

    String choise = Console.ReadLine();

    int choiseint = 0;
    try{
        choiseint = Int16.Parse(choise);
    }
    catch{
        System.Console.WriteLine("This is not a valid choise");
    }

    Console.Clear();

    switch(choiseint) {
        case 0:
            return;
        case 1:
            Console.WriteLine("Give your name: ");
            String Name = Console.ReadLine();

            Person p = new Person();
            p.Name = Name;

            Console.WriteLine(p.SayHello());
            break;
        case 2:
            Console.WriteLine("Give a number: ");
            int number = 0;
            try{
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Multiplication.MultiplicationTable(number));
            }
            catch{
                Console.WriteLine("Not a number");
            }
            break;

        case 3:
            Operation operation = new ();
            Console.WriteLine("Give Number A:");
            try{
                operation.A = Int32.Parse(Console.ReadLine());
            }
            catch{
                Console.WriteLine("Not a valid number");
                break;
            }
            
            Console.WriteLine("Give Number B (not 0):");
            try{
                operation.B = Int32.Parse(Console.ReadLine());
            }
            catch{
                Console.WriteLine("Not a valid number");
                break;
            }
            if(operation.B == 0){
                Console.WriteLine("B cannot be 0");
                break;
            }
            Console.WriteLine(operation.DoOpersations());
            break;

        case 4:
            Console.WriteLine("Enter a sentence (without punctuation marks):");
            String sent = Console.ReadLine();
            FindWord fw = new FindWord();
            Console.WriteLine(fw.GetLongestWord(sent));
            break;

        case 5:
            Console.WriteLine("Enter a word:");
            String word = Console.ReadLine();
            Console.WriteLine(StringLength.GetWordLenght(word));
            break;

        case 6:
            Console.WriteLine("Give a number");
            try{
                int num = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Numbers.PrintNumber(num));
            }
            catch{
                Console.WriteLine("Not a valid number");
            }
            break;

        case 7:
            Console.WriteLine("Give a number");
            try{
                int num = Int32.Parse(Console.ReadLine());
                if(Prime.IsPrime(num)){
                    Console.WriteLine($"{num} is a prime number");
                }
                else{
                    Console.WriteLine($"{num} is a NOT prime number");

                }
            }
            catch{
                Console.WriteLine("Not a valid number");
            }
            break;

        case 8:
            Console.WriteLine("Rectangle of Circle (R | C)");
            String rc = Console.ReadLine();
            switch(rc){
                case "R":
                    int x1, x2, y1, y2;
                    Console.WriteLine("Creating rectangle using coordinates");

                    try{
                        Console.WriteLine("X1:");
                        x1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Y1:");
                        y1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("X2:");
                        x2 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Y2:");
                        y2 = Int32.Parse(Console.ReadLine());
                    }
                    catch{
                        Console.WriteLine("Not a number");
                        break;
                    }

                    try{
                        Rectangle r = new Rectangle(x1,y1,x2,y2);
                        Console.WriteLine($"Rectangle Area = {r.GetArea()}, Rectangle circumference = {r.GetCirc()}");
                    }
                    catch(Exception e){
                        Console.WriteLine(e.Message);
                    }

                    break;
                case "C":

                    Console.WriteLine("Creating circle using coordinate and radius");
                    int cx1, cy1, radius;

                    try{
                        Console.WriteLine("X1:");
                        cx1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Y1:");
                        cy1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Radius:");
                        radius = Int32.Parse(Console.ReadLine());
                    }
                    catch{
                        Console.WriteLine("Not a number");
                        break;
                    }

                    try{
                        Circle c = new Circle(cx1,cy1,radius);
                        Console.WriteLine($"Circle Area = {c.GetArea()}, Circle circumference = {c.GetCirc()}");
                    }
                    catch(Exception e){
                        Console.WriteLine(e.Message);
                    }

                    break;
                default:
                    Console.WriteLine("Not a valid choise");
                    break;
            }
            break;

        case 9:
            Console.WriteLine("Give dividable by 3 word: ");
            String three = Console.ReadLine();
            Console.WriteLine("Give dividable by 5 word: ");
            String five = Console.ReadLine();
            Console.WriteLine("Give max number");
            try{
                int num = Int32.Parse(Console.ReadLine());

                Console.WriteLine(_09_fizzbuzz.FizzBuzz.Run(three, five, num));

            }
            catch{
                Console.WriteLine("Not a valid number");
            }
            break;

        default:
            Console.WriteLine("Not a valid choise");
            break;

    }

    Console.WriteLine("Press key for new exercise");
    Console.ReadKey();
    Console.Clear();


}

void FizzBuzz(string? three, string? five, int num)
{
    throw new NotImplementedException();
}