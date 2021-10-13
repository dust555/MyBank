using System;
using System.Collections.Generic;

namespace DelegatesAndEventsCompany
{

    public delegate Boolean BonusTest(Person p);
    public class Accounting
{

        // public void GiveBonusExp(List<Person> emp){
        //     foreach(Person p in emp){
        //         if(TestExp(p)){
        //             System.Console.WriteLine($"{p.Name} gets {500:c}");
        //         }
        //     }
        // }

        //  public void GiveBonusWage(List<Person> emp){
        //     foreach(Person p in emp){
        //         if(TestWage(p)){
        //             System.Console.WriteLine($"{p.Name} gets {200:c}");
        //         }
        //     }
        // }

         public void GiveBonus(List<Person> emp, BonusTest test){
            foreach(Person p in emp){
                if(test.Invoke(p)){
                    System.Console.WriteLine($"{p.Name} gets {200:c}");
                }
            }
        }

        public void AddEmployee(Person p){
            p.PromoteEvent += Promoted;
        }

        public String Promoted(Person p){
            p.Wage += 500;
            System.Console.WriteLine("Accounting: Promoted");
            return "acc";
        }



        // public static Boolean TestExp(Person p){
        //     return p.Experience > 3;
        // }
        public static Boolean TestWage(Person p){
            return p.Wage < 2000;
        }
    }
}