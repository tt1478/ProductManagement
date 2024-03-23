using ProductManagement.Domain;
using ProductManagement.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.EntityFrameworkCore.Repositories
{
    public class Repository : IRepository
    {
        private readonly ProductManagementDbContext _context;
        public Repository(ProductManagementDbContext context)
        {
            _context = context;
        }
        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
