using GraphGLAPI.Context;
using GraphGLAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphGLAPI.GqlTypes
{
    public class Query
    {
        public async Task<List<Chocolate>> AllChocolateAsync([Service] ChocolateDbContext context)
        {
            return await context.Chocolates.ToListAsync();
        }
    }
}
