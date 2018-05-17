using AutoService.Business.Enums;
using System.Threading.Tasks;

namespace AutoService.Business.Interfaces
{
    public interface IInspectionManager : IDbTableManager
    {
        Task<AddResult> AddRecord(string number, int startYear, int expireYear, bool isPassed, int transportId);

        Task<EditResult> EditRecord(int recordId, string number, int startYear, int expireYear, bool isPassed, int transportId);
    }
}