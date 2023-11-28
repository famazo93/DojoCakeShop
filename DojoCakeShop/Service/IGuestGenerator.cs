using DojoCakeShop.Model;

namespace DojoCakeShop.Service;

public interface IGuestGenerator
{
    public List<Guest> GenerateGuests(int guestNumber);
}