using AngAPI.Entities;

namespace AngAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}