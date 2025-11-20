using Microsoft.EntityFrameworkCore;

namespace PalerIPTSolution.PalerWpfAppFramework
{
    public class DataItemsDbContextFactory
    {
        private readonly DbContextOptions _options;

        public DataItemsDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public DataItemsDbContext Create()
        {
            return new DataItemsDbContext(_options);
        }
    }
}
