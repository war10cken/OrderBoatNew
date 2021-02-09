using System.Collections.Generic;
using System.Threading.Tasks;
using OrderBoatNew.Domain.Models;

namespace OrderBoatNew.Domain.Services
{
    public interface IBoatService
    {
        Task<Boat> GetBoat(BoatType boatType);
    }
}