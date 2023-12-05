using DojoCakeShop.Exception;
using DojoCakeShop.Model;

namespace DojoCakeShop.Service;

public class CakeShop
{
    private readonly ChimneyCakeOven _chimneyCakeOven;
    private readonly PancakeOven _pancakeOven;
    private decimal _profit;

    public CakeShop(ChimneyCakeOven chimneyCakeOven, PancakeOven pancakeOven)
    {
        _chimneyCakeOven = chimneyCakeOven;
        _pancakeOven = pancakeOven;
        _profit = (decimal)0.0;
    }

    public void SellCake(Flavor flavor, CakeType cakeType)
    {
        Cake newCake;
        try
        {
            newCake = (cakeType == CakeType.Pancake
                ? _pancakeOven.Produce(flavor)
                : _chimneyCakeOven.Produce(flavor))!;
        }
        catch (OutOfOilException)
        {
            _pancakeOven.FillOil();
            newCake = _pancakeOven.Produce(flavor);
        }
        
        AddProfit(newCake);
        Console.WriteLine($"We just sold a {newCake}");
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