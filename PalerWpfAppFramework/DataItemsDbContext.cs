using Microsoft.EntityFrameworkCore;
using PalerIPTSolution.PalerWpfAppFramework.DTOs;

namespace PalerIPTSolution.PalerWpfAppFramework
{
    public class DataItemsDbContext : DbContext
    {
        public DataItemsDbContext(DbContextOptions options) : base(options) { }

        public DbSet<DataItemDto> DataItems { get; set; }
    }
}
