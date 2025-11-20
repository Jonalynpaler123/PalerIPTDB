using System;
using System.Threading.Tasks;
using PalerIPTSolution.PalerWpfAppDomain.Commands;
using PalerIPTSolution.PalerWpfAppFramework.DTOs;

namespace PalerIPTSolution.PalerWpfAppFramework.Commands
{
    public class DeleteDataItemCommand : IDeleteDataItemCommand
    {
        private readonly DataItemsDbContextFactory _contextFactory;

        public DeleteDataItemCommand(DataItemsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Guid id)
        {
            using (DataItemsDbContext context = _contextFactory.Create())
            {
                DataItemDto dataItemDto = new DataItemDto() { Id = id };
                context.DataItems.Remove(dataItemDto);
                await context.SaveChangesAsync();
            }
        }
    }
}
