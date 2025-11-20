using System;
using System.Threading.Tasks;

namespace PalerIPTSolution.PalerWpfAppDomain.Commands
{
    public interface IDeleteDataItemCommand
    {
        Task Execute(Guid id);
    }
}
