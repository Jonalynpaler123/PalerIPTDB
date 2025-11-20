using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PalerIPTSolution.PalerWpfAppDomain.Models;
using PalerIPTSolution.PalerWpfAppDomain.Queries;
using PalerIPTSolution.PalerWpfAppFramework.DTOs;

namespace PalerIPTSolution.PalerWpfAppFramework.Queries
{
    public class GetAllDataItemsQuery : IGetAllDataItemsQuery
    {
        private readonly DataItemsDbContextFactory _contextFactory;

        public GetAllDataItemsQuery(DataItemsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<DataItem>> Execute()
        {
            using (DataItemsDbContext context = _contextFactory.Create())
            {
                IEnumerable<DataItemDto> dataItemDtos = await context.DataItems.ToListAsync();

                return dataItemDtos.Select(d => new DataItem(d.Id, d.Name, d.Description, d.CreatedDate));
            }
        }
    }
}
