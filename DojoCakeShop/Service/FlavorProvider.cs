using DojoCakeShop.Model;

namespace DojoCakeShop.Service;

public class FlavorProvider
{
    public IList<Flavor> AvailableFlavors = new List<Flavor>()
    {
        new Flavor("Vanilla", (decimal)0.30),
        new Flavor("Chocolate", (decimal)0.40),
        new Flavor("Strawberry", (decimal)0.55)
    };
}