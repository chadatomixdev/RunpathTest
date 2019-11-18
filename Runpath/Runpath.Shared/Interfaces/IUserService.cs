using Runpath.Data.Models;

namespace Runpath.Shared.Interfaces
{
    public interface IUserService
    {
        User GetUserByID(int id);
    }
}