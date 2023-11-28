using DojoCakeShop.Model;

namespace DojoCakeShop.Service;

public class CakeShop
{
    private ChimneyCakeOven _chimneyCakeOven;
    private PancakeOven _pancakeOven;
    private decimal _profit;

    public CakeShop(ChimneyCakeOven chimneyCakeOven, PancakeOven pancakeOven)
    {
        _chimneyCakeOven = chimneyCakeOven;
        _pancakeOven = pancakeOven;
        _profit = (decimal)0.0;
    }

    public void SellCake(Flavor flavor, CakeType cakeType)
    {
        Cake? newCake = cakeType == CakeType.Pancake
            ? _pancakeOven.ProducePancake(flavor)
            : _chimneyCakeOven.ProduceChimneyCake(flavor);

        while (newCake == null)
        {
            _pancakeOven.FillOil();
            newCake = _pancakeOven.ProducePancake(flavor);
        }
        
        AddProfit(newCake);
        Console.WriteLine($"We just sold a {newCake.ToString()}");
    }

    private void AddProfit(Cake cake)
    {
        _profit += cake.Price;
    }

    public void CalculateProfit()
    {
        Console.WriteLine($"Today's profit has been ${_profit}.");
    }
}