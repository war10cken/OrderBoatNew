using System.Collections.Generic;
using System.Threading.Tasks;
using OrderBoatNew.Domain.Models;

namespace OrderBoatNew.Domain.Services
{
    public interface IColorService : IDataService<Color>
    {
        Task<IEnumerable<Color>> GetFreeColor();
        Task<IEnumerable<Color>> GetColorForAdditionalPrice();
    }
}