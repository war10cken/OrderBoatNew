﻿using System.Collections.Generic;
using System.Threading.Tasks;
using OrderBoatNew.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OrderBoatNew.Domain.Models;

namespace OrderBoatNew.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly OrderBoatNewDbContextFactory _contextFactory;

        public GenericDataService(OrderBoatNewDbContextFactory contextFactory) { _contextFactory = contextFactory; }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (OrderBoatNewDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();

                return entities;
            }
        }

        public async Task<T> Get(int id)
        {
            using (OrderBoatNewDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.ID == id);

                return entity;
            }
        }

        public async Task<T> Create(T entity)
        {
            using (OrderBoatNewDbContext context = _contextFactory.CreateDbContext())
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (OrderBoatNewDbContext context = _contextFactory.CreateDbContext())
            {
                entity.ID = id;

                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (OrderBoatNewDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.ID == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }
    }
}