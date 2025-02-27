namespace oop_labs;

public class CargoPlane: Plane
{
    public enum CargoPlaneType
    {
        InCountry,
        International,
        Intercontinental
    }
    public override string pictureURL => "/Users/pavelplayerz0redd/Documents/transport-images/cargo-plane.jpg";
    public CargoPlaneType cargoPlaneType { get; set; }
    public int maxDistance { get; set; }
}