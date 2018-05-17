using AutoService.Business.Enums;
using System.Threading.Tasks;

namespace AutoService.Business.Interfaces
{
    public interface IDriverLicenseManager : IDbTableManager
    {
        Task<AddResult> AddRecord(string number, int year, int month, int day, int transportCategoryId, int clientId);

        Task<EditResult> EditRecord(int recordId, string number, int year, int month, int day, int transportCategoryId, int clientId);
    }
}