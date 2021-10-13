using System;
using System.Collections.Generic;
using InterfaceAnimalVehicleShape.Animals;
using InterfaceAnimalVehicleShape.Shapes;
using InterfaceAnimalVehicleShape.Vehicles;

namespace InterfaceAnimalVehicleShape
{
    class Program
    {

        static void Race(ICanRace r1, ICanRace r2){
            if(r1.Speed > r2.Speed){
                System.Console.WriteLine($"{r1.Name} is faster than {r2.Name} with a speed of {r1.Speed}");
            }
            else if(r1.Speed < r2.Speed){
                System.Console.WriteLine($"{r2.Name} is faster than {r1.Name} with a speed of {r2.Speed}");
            }
            else{
                System.Console.WriteLine("Same speed");
            }
        }

        static void CompareVolumes(IHasVolume v1, IHasVolume v2){
            if(v1.Volume < v2.Volume){
                System.Console.WriteLine($"{v1.Name} is larger than {v2.Name} with");
            }
        }

        static void MakeAllSounds(params List<ICanMakeSound>[] arr){
            foreach(List<ICanMakeSound> list in arr){
                foreach(ICanMakeSound s in list){
                    s.MakeSound();
                }
            }
        }





        static void Main(string[] args)
        {
            Cat a1 = new Cat(){Name="Kity", Speed=20, Sound="Miauw", Volume=200};
            Dog a2 = new Dog(){Name="Brutus", Speed=30, Sound="Woof",Volume=500};
            Cat a3 = new Cat(){Name="Fanny", Speed=15, Sound="Miauw", Volume=100};
            Car c1 = new Car(){Name="Volvo", Speed=100, Sound = "Vroom", Volume=2000};
            Car c2 = new Car(){Name="RangeRover", Speed=80, Sound = "Vroom", Volume=3000};
            Cube s1 = new Cube(){Name="Cube1", Volume=1000};
            Cube s2 = new Cube(){Name="Volvo", Volume=500};

            List<ICanMakeSound> animallist = new List<ICanMakeSound>();
            List<ICanMakeSound> vehiclelist = new List<ICanMakeSound>();


            animallist.Add(a1);
            animallist.Add(a1);
            animallist.Add(a1);
            vehiclelist.Add(c2);
            vehiclelist.Add(c2);
            vehiclelist.Add(c2);

            MakeAllSounds(animallist, vehiclelist);

            Race(a1,c2);
            Race(a1,c2);
            Race(a1,c2);

            CompareVolumes(s1,s2);
            CompareVolumes(a1,s2);
            CompareVolumes(a1,c2);
            CompareVolumes(a2,c1);

        }
    }
}
