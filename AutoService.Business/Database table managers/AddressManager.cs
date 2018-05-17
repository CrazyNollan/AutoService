using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using AutoService.Business.Enums;
using AutoService.Business.Interfaces;
using AutoService.Data;
using AutoService.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Business.Database.Table.Managers
{
    public class AddressManager : IAddressManager
    {
        private readonly DatabaseContext dbContext;

        internal AddressManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AddResult> AddRecord(string country, string city, string street, int house)
        {
            AddressEntity addressEntity = new AddressEntity { Country = country, City = city, Street = street, House = house };

            await dbContext.Addresses.AddAsync(addressEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.Addresses.AnyAsync(a => a.Id == addressEntity.Id))
            {
                return AddResult.Success;
            }

            return AddResult.Failed;
        }

        public async Task<DeleteResult> DeleteRecord(int recordId)
        {
            AddressEntity addressEntity = await dbContext.Addresses.FirstOrDefaultAsync(a => a.Id == recordId);

            if (addressEntity == null)
            {
                return DeleteResult.RecordNotFound;
            }

            dbContext.Addresses.Remove(addressEntity);
            await dbContext.SaveChangesAsync();

            if (!await dbContext.Addresses.AnyAsync(a => a.Id == addressEntity.Id))
            {
                return DeleteResult.Success;
            }

            return DeleteResult.Failed;
        }

        public Task<EditResult> EditRecord(int recordId, string country, string city, string street, int house)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string[]>> GetDataAsync()
        {
            List<string[]> data = new List<string[]>();

            foreach (var address in dbContext.Addresses)
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = address.Id.ToString();
                data[data.Count - 1][1] = address.Country.ToString();
                data[data.Count - 1][2] = address.City.ToString();
                data[data.Count - 1][3] = address.Street.ToString();
                data[data.Count - 1][4] = address.House.ToString();
            }

            return await Task.FromResult(data);
        }
    }
}