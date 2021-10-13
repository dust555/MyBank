namespace DelegatesAndEventsCompany
{
    public class MessageBoard
    {
        public string Name { get; set; }

        public void WriteMessage(string message){
            System.Console.WriteLine(message);
        }

        public string Promoted(Person p){
            WriteMessage($"Message {Name}: Congrats {p.Name} is now {p.Level}");
            return Name;
        }

        public void AddEmployee(Person p){
            p.PromoteEvent += Promoted;
        }
    }
}