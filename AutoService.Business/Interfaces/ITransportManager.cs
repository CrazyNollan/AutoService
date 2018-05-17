using AutoService.Business.Enums;
using System.Threading.Tasks;

namespace AutoService.Business.Interfaces
{
    public interface ITransportManager : IDbTableManager
    {
        Task<AddResult> AddRecord(string number, int transportMakeId, int transportModelId, int fuelId, int transportCategoryId, int clientId);

        Task<EditResult> EditRecord(int recordId, string number, int transportMakeId, int transportModelId, int fuelId, int transportCategoryId, int clientId);
    }
}