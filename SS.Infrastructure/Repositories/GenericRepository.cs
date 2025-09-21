using Microsoft.EntityFrameworkCore;
using SS.Core.Interfaces;
using SS.Infrastructure.appDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SchoolDbContext context;
        protected readonly DbSet<T> dbSet;
        public GenericRepository(SchoolDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }
    }
}
