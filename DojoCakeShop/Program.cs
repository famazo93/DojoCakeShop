using DojoCakeShop.Model;
using DojoCakeShop.Service;

namespace DojoCakeShop;

public static class Program
{
    public static void Main(string[] args)
    {
        ChimneyCakeOven chimneyCakeOven = new ChimneyCakeOven();
        PancakeOven pancakeOven = new PancakeOven();
        CakeShop newShop = new CakeShop(chimneyCakeOven, pancakeOven);
        FlavorProvider flavorProvider = new FlavorProvider();
        IGuestGenerator guestGenerator = new GuestGenerator(flavorProvider);

        List<Guest> guests = guestGenerator.GenerateGuests(50);
        foreach (Guest guest in guests)
        {
            newShop.SellCake(guest.PreferredFlavor, guest.PreferredCake);
        }
        
        newShop.CalculateProfit();
    }
}