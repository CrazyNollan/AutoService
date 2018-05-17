using AutoService.Business.Enums;
using AutoService.Business.Interfaces;
using AutoService.Data;
using AutoService.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoService.Business.Database.Table.Managers
{
    public class DriverLicenseManager : IDriverLicenseManager
    {
        private readonly DatabaseContext dbContext;

        internal DriverLicenseManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AddResult> AddRecord(string number, int year, int month, int day, int transportCategoryId, int clientId)
        {
            DriverLicenseEntity driverLicenseEntity = new DriverLicenseEntity { Number = number, Year = year, Month = month, Day = day, TransportCategoryId = transportCategoryId, ClientId = clientId };

            await dbContext.DriverLicenses.AddAsync(driverLicenseEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.DriverLicenses.AnyAsync(dl => dl.Id == driverLicenseEntity.Id))
            {
                return AddResult.Success;
            }

            return AddResult.Failed;
        }

        public async Task<DeleteResult> DeleteRecord(int recordId)
        {
            DriverLicenseEntity driverLicenseEntity = await dbContext.DriverLicenses.FirstOrDefaultAsync(a => a.Id == recordId);

            if (driverLicenseEntity == null)
            {
                return DeleteResult.RecordNotFound;
            }

            dbContext.DriverLicenses.Remove(driverLicenseEntity);
            await dbContext.SaveChangesAsync();

            if (!await dbContext.DriverLicenses.AnyAsync(a => a.Id == driverLicenseEntity.Id))
            {
                return DeleteResult.Success;
            }

            return DeleteResult.Failed;
        }

        public Task<EditResult> EditRecord(int recordId, string number, int year, int month, int day, int transportCategoryId, int clientId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string[]>> GetDataAsync()
        {
            List<string[]> data = new List<string[]>();

            foreach (var license in dbContext.DriverLicenses.Include(ts => ts.TransportCategory))
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = license.Id.ToString();
                data[data.Count - 1][1] = license.Number.ToString();
                data[data.Count - 1][2] = license.Year.ToString();
                data[data.Count - 1][3] = license.Month.ToString();
                data[data.Count - 1][4] = license.Day.ToString();
                data[data.Count - 1][5] = license.TransportCategory.Name.ToString();
                data[data.Count - 1][6] = license.ClientId.ToString();
            }

            return await Task.FromResult(data);
        }
    }
}