using DojoCakeShop.Model;

namespace DojoCakeShop.Service;

public class GuestGenerator : IGuestGenerator
{
    private FlavorProvider _flavorProvider;

    public GuestGenerator(FlavorProvider flavorProvider)
    {
        _flavorProvider = flavorProvider;
    }
    public List<Guest> GenerateGuests(int guestNumber)
    {
        List<Guest> guests = new();
        Random random = new Random();
        for (int i = 1; i <= guestNumber; i++)
        {
            Flavor randomFlavor =
                _flavorProvider.AvailableFlavors[random.Next(0, _flavorProvider.AvailableFlavors.Count)];
            CakeType randomCakeType = (CakeType)random.Next(0, Enum.GetValues(typeof(CakeType)).Length);
            guests.Add(new Guest(randomFlavor, randomCakeType));
        }

        return guests;
    }
}