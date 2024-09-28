using CleanArchWithSolidPrincipal.Domain.Entities;
using CleanArchWithSolidPrincipal.Domain.RepositoryInterface;
using CleanArchWithSolidPrincipal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchWithSolidPrincipal.Infrastructure.RepositoryImplementation
{
    public class ProductRepository(AppDbContext appDbContext) : IProductRepository
    {
        public async Task AddAsync(Product product)
        {
            appDbContext.Products.Add(product);
            await appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await appDbContext.Products.FindAsync(id);
            if (product != null)
            {
                appDbContext.Products.Remove(product);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync() =>
            await appDbContext.Products.AsNoTracking().ToListAsync();


        public async Task<Product?> GetByIdAsync(int id) =>
            await appDbContext.Products.FirstAsync(x => x.Id == id);

        public async Task UpdateAsync(Product product)
        {
            appDbContext.Products.Update(product);
            await appDbContext.SaveChangesAsync();
        }
    }
}
