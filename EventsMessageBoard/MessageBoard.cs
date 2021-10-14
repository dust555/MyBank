using System;

namespace EventsMessageBoard
{
    public class MessageBoard
    {

        public MessageBoard(Observer o)
        {
            o.SendMessage += SendDiv10Message;
        }

        public String Name { get; set; }

        public void SendDiv10Message(int num){
            PrintMessage($"{num} by 10");
        }

        public void PrintMessage(string message){
            System.Console.WriteLine($"{Name}: {message}");
        }
        
    }
}