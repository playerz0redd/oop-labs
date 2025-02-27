namespace oop_labs;

public class Truck: Car
{
    public override string pictureURL => "/Users/pavelplayerz0redd/Documents/transport-images/truck.jpg";
    public int truckId { get; set; }
    public int maxWeight { get; set; }
    public int currentWeight { get; set; }
    
    
}