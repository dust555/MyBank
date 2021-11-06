using System;

namespace MyList
{
    public class Animal:IHasId
    {
        public int Id { get; set; }
        public String Breed { get; set; }
    }
}