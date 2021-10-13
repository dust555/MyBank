using System;

namespace InterfaceAnimalVehicleShape.Vehicles
{
    public abstract class Vehicle : ICanRace,IHasVolume, ICanMakeSound
    {
        public int Speed { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public String Sound { get; set; }

        public void MakeSound()
        {
            System.Console.WriteLine($"{Name} does {Sound}");
        }
    }
}