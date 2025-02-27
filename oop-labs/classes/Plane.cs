namespace oop_labs;

public class Plane: Transport
{
    public enum WingType
    {
       monoplane,
       biplane, 
       triplane,
       multiplane
    }
    public override string pictureURL => "/Users/pavelplayerz0redd/Documents/transport-images/plane.jpg";
    public WingType wingType { get; set; }
    public int raceID { get; set; }
    public bool WiFiAvailable { get; set; }
    public int carcaseWeight { get; set; }
}