namespace DojoCakeShop.Model;

public class ChimneyCakeOven : Oven, IOven
{
    private decimal price;

    public ChimneyCakeOven() : base()
    {
        price = (decimal)2.0;
    }

    public Cake? Produce(Flavor flavor)
    {
        return ProduceCake(flavor, CakeType.ChimneyCake, price);
    }
}