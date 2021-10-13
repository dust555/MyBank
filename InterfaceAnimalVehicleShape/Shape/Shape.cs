namespace InterfaceAnimalVehicleShape.Shapes
{
    public abstract class Shape:IHasVolume
    {
        public string Name { get; set; }
        public int Volume { get; set; }
    }
}