using System.Threading.Tasks;
using PalerIPTSolution.PalerWpfAppDomain.Commands;
using PalerIPTSolution.PalerWpfAppDomain.Models;
using PalerIPTSolution.PalerWpfAppFramework.DTOs;

namespace PalerIPTSolution.PalerWpfAppFramework.Commands
{
    public class CreateDataItemCommand : ICreateDataItemCommand
    {
        private readonly DataItemsDbContextFactory _contextFactory;

        public CreateDataItemCommand(DataItemsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(DataItem dataItem)
        {
            using (DataItemsDbContext context = _contextFactory.Create())
            {
                DataItemDto dataItemDto = new DataItemDto()
                {
                    Id = dataItem.Id,
                    Name = dataItem.Name,
                    Description = dataItem.Description,
                    CreatedDate = dataItem.CreatedDate
                };

                context.DataItems.Add(dataItemDto);
                await context.SaveChangesAsync();
            }
        }
    }
}
