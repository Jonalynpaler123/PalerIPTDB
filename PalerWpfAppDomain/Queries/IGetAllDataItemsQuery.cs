using System.Collections.Generic;
using System.Threading.Tasks;
using PalerIPTSolution.PalerWpfAppDomain.Models;

namespace PalerIPTSolution.PalerWpfAppDomain.Queries
{
    public interface IGetAllDataItemsQuery
    {
        Task<IEnumerable<DataItem>> Execute();
    }
}
