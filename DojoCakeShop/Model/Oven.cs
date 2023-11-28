namespace DojoCakeShop.Model;

public class Oven
{
    protected Cake ProduceCake(Flavor flavor, CakeType type, decimal price)
    {
        return new Cake(type, flavor, price);
    }
}