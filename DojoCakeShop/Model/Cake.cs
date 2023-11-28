using System.Diagnostics;

namespace DojoCakeShop.Model;

public class Cake
{
    private Flavor CakeFlavor { get; }
    public decimal Price { get; }
    private CakeType TypeOfCake { get; }

    public Cake(CakeType type, Flavor flavor, decimal price)
    {
        CakeFlavor = flavor;
        TypeOfCake = type;
        Price = price + CakeFlavor.Price;
    }

    public override string ToString()
    {
        return $"{TypeOfCake} with {CakeFlavor.FlavorName} flavor.";
    }
}