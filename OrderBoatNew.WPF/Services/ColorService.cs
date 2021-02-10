using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services;
using OrderBoatNew.EntityFramework;
using OrderBoatNew.EntityFramework.Services.Common;

namespace OrderBoatNew.WPF.Services
{
    public class ColorService : IColorService
    {
        private readonly OrderBoatNewDbContextFactory _contextFactory;
        private readonly NonQueryDataService<Color> _nonQueryDataService;

        public ColorService(OrderBoatNewDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonQueryDataService<Color>(contextFactory);
        }

        public async Task<IEnumerable<Color>> GetAll() => await _nonQueryDataService.GetAll();

        public async Task<Color> Get(int id) => await _nonQueryDataService.Get(id);

        public async Task<Color> Create(Color entity) => await _nonQueryDataService.Create(entity);

        public async Task<Color> Update(int id, Color entity) => await _nonQueryDataService.Update(id, entity);

        public async Task<bool> Delete(int id) => await _nonQueryDataService.Delete(id);

        public async Task<IEnumerable<Color>> GetFreeColor()
        {
            using (OrderBoatNewDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Color> freeColors = await context.Colors
                                                             .Where(c => c.ForAdditionalMoney == false)
                                                             .ToListAsync();

                return freeColors;
            }
        }

        public async Task<IEnumerable<Color>> GetColorForAdditionalPrice()
        {
            using (OrderBoatNewDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Color> colorsForAdditionalPrice = await context.Colors
                                                                           .Where(c => c.ForAdditionalMoney)
                                                                           .ToListAsync();

                return colorsForAdditionalPrice;
            }
            
        }
    }
}