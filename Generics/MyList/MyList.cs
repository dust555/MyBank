using System.Collections.Generic;

namespace MyList
{
    public class MyList<T> where T : IHasId
    {
        public List<T> List {get; set;} = new List<T>();

        public void AddToList(T item){
            foreach(T i in List){
                if(i.Id == item.Id){
                    System.Console.WriteLine("Id Already exists");
                    return;
                }
            }
            List.Add(item);
        }
    }
}