using System;

namespace InterfaceAnimalVehicleShape.Animals
{
    public abstract class Animal:ICanRace,IHasVolume,ICanMakeSound
    {
        public int Speed { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public String Sound { get; set; }

        public void MakeSound()
        {
            System.Console.WriteLine($"{Name} says {Sound}");
        }
    }
}