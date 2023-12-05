using DojoCakeShop.Exception;

namespace DojoCakeShop.Model;

public class PancakeOven : Oven, IOven
{
    private static int _numberOfCakesBaked = 0;
    private bool _hasOil = _numberOfCakesBaked < 5;
    private readonly decimal _price = (decimal)1.0;


    public Cake Produce(Flavor flavor)
    {
        Console.WriteLine(_numberOfCakesBaked);
        Console.WriteLine(_hasOil);
        if (_hasOil)
        {
            _numberOfCakesBaked++;
            _hasOil = _numberOfCakesBaked < 5;
            return ProduceCake(flavor, CakeType.Pancake, _price);
        }
        throw new OutOfOilException();
    }

    public void FillOil()
    {
        Console.WriteLine("!!! Refilling oil in the pancake oven !!!");
        _numberOfCakesBaked = 0;
        _hasOil = true;
    }
}