using AutoService.Business.Enums;
using System.Threading.Tasks;

namespace AutoService.Business.Interfaces
{
    public interface ITransportModelManager : IDbTableManager
    {
        Task<AddResult> AddRecord(string name);

        Task<EditResult> EditRecord(int recordId, string name);
    }
}