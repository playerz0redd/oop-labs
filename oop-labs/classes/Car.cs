using System.Reflection;

namespace oop_labs;

public class Car : Transport
{
    public enum BodyType
    {
        sedan,
        hatchback,
        offRoad
    }

    public override string pictureURL => "/Users/pavelplayerz0redd/Documents/transport-images/car.jpg";
    public int gears { get; set; }
    public int doorAmount { get; set; }
    public string engineType { get; set; }
    public int year { get; set; }
    public BodyType bodyType { get; set; }
    public int airBagCount { get; set; }
    
    public double engineVolume { get; set; }
    
    public double fuelConsumption { get; set; }
    
    public double CalculateRemainingRange()
    {
        return (this.fuelAmount / this.fuelConsumption) * 100;
    }

    public string EngineStart()
    {
        return "Двигатель запущен";
    }
    
    public string EngineStop()
    {
        return "Двигатель заглушен";
    }
    
}