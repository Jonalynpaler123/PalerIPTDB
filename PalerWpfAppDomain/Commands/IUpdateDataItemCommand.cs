using System.Threading.Tasks;
using PalerIPTSolution.PalerWpfAppDomain.Models;

namespace PalerIPTSolution.PalerWpfAppDomain.Commands
{
    public interface IUpdateDataItemCommand
    {
        Task Execute(DataItem dataItem);
    }
}
