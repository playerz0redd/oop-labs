namespace oop_labs;

public class SportCar: Car
{
    public enum CarClass
    {
        Race, 
        Rally,
        Formula,
        Drift
    }
    public override string pictureURL => "/Users/pavelplayerz0redd/Documents/transport-images/sport-car.jpg";
    public CarClass carClass { get; set; }
    public string transmitionType { get; set; }
    
}