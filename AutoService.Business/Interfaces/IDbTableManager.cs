using AutoService.Business.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoService.Business.Interfaces
{
    public interface IDbTableManager
    {
        Task<IEnumerable<string[]>> GetDataAsync();

        Task<DeleteResult> DeleteRecord(int recordId);
    }
}