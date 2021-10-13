using System;

namespace InterfaceAnimalVehicleShape
{
    public interface ICanRace:IHasName
    {
         int Speed { get; set; }
    }
}