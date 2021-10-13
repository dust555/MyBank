using System;

namespace DelegatesAndEventsCompany
{

    public delegate int DoStuff(int i);

    public delegate String PromoteEvent(Person p);

    public enum Levels{
        Starter,
        Intermediate,
        Expert
    }

    public class Person
    {

        public int Energy { get; set; }

        public event PromoteEvent PromoteEvent;

        public String Name { get; set; }
        public int Experience { get; set; }

        public int Wage { get; set; }

        public Levels Level { get; set; } = Levels.Starter;

        public void Promote(){
            if(Level < Levels.Expert){
                Level++;
                String s = PromoteEvent(this);
                System.Console.WriteLine(s);
            }
        }

        public void WakeUp(){
            System.Console.WriteLine("Wake Up");
        }
        public int Eat(int i){
            System.Console.WriteLine("Eat");
            Energy = Energy+10;
            return Energy;
        }
        public int Work(int i){
            System.Console.WriteLine("Work");
            Energy = Energy - 30;
            return Energy;
        }
        public int Relax(int i){
            System.Console.WriteLine("Relax");
            Energy = Energy-5;
            return Energy;
        }
        public void Sleep(){
            System.Console.WriteLine("Go To Sleep");
        }

        // public void WorkingDay(){
        //     WakeUp();
        //     Eat();
        //     Work();
        //     Eat();
        //     Work();
        //     Eat();
        //     Relax();
        //     Sleep();
        // }

        // public void Weekend(){
        //     WakeUp();
        //     Eat();
        //     Relax();
        //     Eat();
        //     Relax();
        //     Eat();
        //     Relax();
        //     Sleep();
        // }

        public void GenericDay(DoStuff todo){
            WakeUp();
            Eat(5);
            Energy = 100;
            int i = todo.Invoke(500);
            Eat(5);
            Relax(5);
            Sleep();

            System.Console.WriteLine(i);
        }
    }
}