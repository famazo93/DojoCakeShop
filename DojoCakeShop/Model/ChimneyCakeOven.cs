namespace DojoCakeShop.Model;

public class ChimneyCakeOven : Oven
{
    private decimal price;

    public ChimneyCakeOven() : base()
    {
        price = (decimal)2.0;
    }

    public Cake? ProduceChimneyCake(Flavor flavor)
    {
        return ProduceCake(flavor, CakeType.ChimneyCake, price);
    }
}