using Runpath.Data.Models;
using Runpath.Data.Services;
using Runpath.Shared.Interfaces;
using System.Linq;

namespace Runpath.Shared.Services
{
    public class UserService : IUserService
    {
        private readonly RepositoryService _contextService;

        public UserService(RepositoryService contextService)
        {
            _contextService = contextService;
        }

        /// <summary>
        /// Get user by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUserByID(int id)
        {
            return _contextService.Find<User>(u => u.UserID == id).FirstOrDefault();
        }
    }
}