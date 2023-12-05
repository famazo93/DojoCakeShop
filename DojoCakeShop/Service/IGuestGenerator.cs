using DojoCakeShop.Model;

namespace DojoCakeShop.Service;

public interface IGuestGenerator
{
    public IList<Guest> GenerateGuests(int guestNumber);
}