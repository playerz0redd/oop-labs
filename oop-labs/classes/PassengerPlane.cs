namespace oop_labs;

public class PassengerPlane: Plane
{
    private const int AVERAGE_PERSON_WEIGHT = 80;
    public override string pictureURL => "/Users/pavelplayerz0redd/Documents/transport-images/pass-plane.jpg";
    
    public int numberOfSeats { get; set; }
    public int NumberOfFlightAttendants { get; set; }
    public int EconomyClassSeats { get; set; }
    public int peopleAmount { get; set; }

    public int LuggageCapacity { get; set; }
    public int LuggageCount { get; set; }

    public int calculateCurrWeight()
    {
        return peopleAmount * AVERAGE_PERSON_WEIGHT + carcaseWeight + LuggageCount;
    }
}