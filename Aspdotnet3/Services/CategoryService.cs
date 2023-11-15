using Aspdotnet3.Data;
using Aspdotnet3.Models;
using Microsoft.EntityFrameworkCore;

namespace Aspdotnet3.Services
{
    public class CategoryService
    {
        private readonly AppDbContext context;
        public CategoryService(AppDbContext context) 
        {
            this.context = context;
        }
        public async Task<List<Category>> GetListAsync() => await context.Category.ToListAsync();
        public async Task<Category> Create(Category category)
        {
            context.Add(category);
            await context.SaveChangesAsync();
            return category;
        }
    }
}
