using System;

namespace EventsMessageBoard
{

    public delegate void SendMessageDel(int num);

    public class Observer
    {

        public event SendMessageDel SendMessage;
        public void Observe(){

            int count = 0;

            while(true){
                Console.ReadKey();
                count++;

                if(count % 10 == 0){
                    SendMessage(count);
                }
            }
        }
        
    }
}