using System.Collections.Generic;

namespace DelegatesAndEventsCompany
{
    public class Company
    {
        public List<Person> Employees = new List<Person>();

        public Accounting acc = new Accounting();

        public List<MessageBoard> MessageBoards = new List<MessageBoard>();

        public Company()
        {
            MessageBoards.Add(new MessageBoard(){Name = "m1"});
            MessageBoards.Add(new MessageBoard(){Name = "m2"});
            MessageBoards.Add(new MessageBoard(){Name = "m3"});
        }

        public void AddEmployee(Person p){
            Employees.Add(p);
            foreach(MessageBoard mb in MessageBoards){
                mb.AddEmployee(p);
            }
            acc.AddEmployee(p);
        }



    }
}