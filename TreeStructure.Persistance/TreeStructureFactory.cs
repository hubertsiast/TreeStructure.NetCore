using Microsoft.EntityFrameworkCore;
using TreeStructure.Persistance;

namespace Persistence
{
    public class TreeStructureDbContextFactory : DesignTimeDbContextFactoryBase<TreeStructureDbContext>
    {
        protected override TreeStructureDbContext CreateNewInstance(DbContextOptions<TreeStructureDbContext> options)
        {
            return new TreeStructureDbContext(options);
        }
    }
}