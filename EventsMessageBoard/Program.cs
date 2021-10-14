using System;

namespace EventsMessageBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer observ = new Observer();

            MessageBoard m1 = new MessageBoard(observ){Name = "m1"};
            MessageBoard m2 = new MessageBoard(observ){Name = "m2"};

            observ.Observe();
        }
    }
}
