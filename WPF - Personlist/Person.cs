using System;

namespace wpf
{
    public class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        new public String ToString(){
            return FirstName + " " + LastName;
        }
    }
}