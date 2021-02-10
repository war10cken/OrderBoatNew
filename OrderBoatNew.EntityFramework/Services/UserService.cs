using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services;
using OrderBoatNew.EntityFramework.Services.Common;

namespace OrderBoatNew.EntityFramework.Services
{
    public class UserService : IUserService
    {
        private readonly OrderBoatNewDbContextFactory _contextFactory;
        private readonly NonQueryDataService<User> _nonQueryDataService;
        
        public UserService(OrderBoatNewDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonQueryDataService<User>(contextFactory);
        }

        public async Task<IEnumerable<User>> GetAll() => await _nonQueryDataService.GetAll();

        public async Task<User> Get(int id) => await _nonQueryDataService.Get(id);

        public async Task<User> Create(User entity) => await _nonQueryDataService.Create(entity);

        public async Task<User> Update(int id, User entity) => await _nonQueryDataService.Update(id, entity);

        public async Task<bool> Delete(int id) => await _nonQueryDataService.Delete(id);

        public async Task<User> GetByUserName(string username)
        {
            using (OrderBoatNewDbContext context = _contextFactory.CreateDbContext())
            {
                return await context.Users.FirstOrDefaultAsync(u => u.Username == username);
            }
        }

        public async Task<User> GetByEmail(string email)
        {
            using (OrderBoatNewDbContext context = _contextFactory.CreateDbContext())
            {
                return await context.Users.FirstOrDefaultAsync(u => u.Email == email);
            }
        }
    }
}