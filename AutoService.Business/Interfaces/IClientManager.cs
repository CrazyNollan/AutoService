using AutoService.Business.Enums;
using System.Threading.Tasks;

namespace AutoService.Business.Interfaces
{
    public interface IClientManager : IDbTableManager
    {
        Task<AddResult> AddRecord(string name, string surname, string patronymic, string email, int addressId);

        Task<EditResult> EditRecord(int recordId, string name, string surname, string patronymic, string email, int addressId);
    }
}