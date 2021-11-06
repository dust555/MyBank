using System;

namespace MyList
{
    public class Person:IHasId
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
}