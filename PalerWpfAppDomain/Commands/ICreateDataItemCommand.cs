using System.Threading.Tasks;
using PalerIPTSolution.PalerWpfAppDomain.Models;

namespace PalerIPTSolution.PalerWpfAppDomain.Commands
{
    public interface ICreateDataItemCommand
    {
        Task Execute(DataItem dataItem);
    }
}
