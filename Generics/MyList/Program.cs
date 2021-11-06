using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(){Id=1, Name="jack"};
            Person p2 = new Person(){Id=2, Name="ann"};

            MyList<Person> PersonList = new MyList<Person>();

            PersonList.AddToList(p);
            PersonList.AddToList(p2);

            Animal a = new Animal(){Id=1, Breed="Dog"};
            MyList<Animal> AnimalList = new MyList<Animal>();
            AnimalList.AddToList(a);


        }
    }
}
