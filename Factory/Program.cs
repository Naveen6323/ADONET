


public class VehicleFactory
{
    public static IVehicle GetVehicle(string type)
    {
        return type.ToLower() switch
        {
            "car" => new Car(),
            "bike" => new Bike(),
            "truck" => new Truck(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}

public class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Driving a Car!");
}

public class Bike : IVehicle
{
    public void Drive() => Console.WriteLine("Riding a Bike!");
}

public class Truck : IVehicle
{
    public void Drive() => Console.WriteLine("Driving a Truck!");
}
public interface IVehicle
{
    void Drive();
}

