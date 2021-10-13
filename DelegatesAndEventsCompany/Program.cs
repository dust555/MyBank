using System;

namespace DelegatesAndEventsCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person p = new Person();

            // DoStuff todo = p.Work;
            // todo += p.Eat;
            // todo += p.Relax;



            // p.GenericDay(todo);
            
            
            //p.GenericDay(p.Relax, p.Work);

            Company MyCompany = new Company();

            MyCompany.AddEmployee(new Person(){Name="Jack", Wage=2000, Experience=2});
            MyCompany.AddEmployee(new Person(){Name="Jan", Wage=3000, Experience=3});
            MyCompany.AddEmployee(new Person(){Name="An", Wage=1000, Experience=4});
            MyCompany.AddEmployee(new Person(){Name="Kate", Wage=1500, Experience=10});

            BonusTest testwage =  p => p.Experience > 3;


            MyCompany.acc.GiveBonus(MyCompany.Employees,Accounting.TestWage);
            MyCompany.acc.GiveBonus(MyCompany.Employees,testwage);

            MyCompany.Employees[0].Promote();


        }
    }
}
