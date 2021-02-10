using System.Threading.Tasks;
using OrderBoatNew.Domain.Models;

namespace OrderBoatNew.Domain.Services
{
    public interface IUserService : IDataService<User>
    {
        Task<User> GetByUserName(string username);
        Task<User> GetByEmail(string email);
    }
}