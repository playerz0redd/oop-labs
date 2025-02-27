using System.Dynamic;
using System.Reflection;

namespace oop_labs;

public abstract class Transport
{
    public enum FuelType
    {
        Petrol,
        Diesel,
        Gas,
        Kerosene
    }

    public static int objectAmount = 0;
    public int maxSpeed { get; set; }
    public string brand { get; set; }
    public FuelType fuelType { get; set; }
    public string from { get; set; }
    public string destination { get; set; }
    public int EngineRPM { get; set; }
    public int horsePower { get; set; }
    public int fuelTankCapacity { get; set; }
    public double fuelAmount { get; set; }
    
    public void fillUp(double amount)
    {
        this.fuelAmount += amount;
    }
    
    
    public override string ToString()
    {
        string result = "";
        foreach (PropertyInfo property in this.GetType().GetProperties())
        {
            result += property.Name + " : " + property.GetValue(this) + "\n";
        }
        return result;
    }

    public virtual string pictureURL => "/Users/pavelplayerz0redd/Documents/transport-images/transport.jpg";


}