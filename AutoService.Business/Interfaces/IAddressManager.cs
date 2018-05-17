using AutoService.Business.Enums;
using System.Threading.Tasks;

namespace AutoService.Business.Interfaces
{
    public interface IAddressManager : IDbTableManager
    {
        Task<AddResult> AddRecord(string country, string city, string street, int house);

        Task<EditResult> EditRecord(int recordId, string country, string city, string street, int house);
    }
}