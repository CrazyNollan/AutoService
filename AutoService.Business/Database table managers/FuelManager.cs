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
    public class FuelManager : IFuelManager
    {
        private readonly DatabaseContext dbContext;

        internal FuelManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AddResult> AddRecord(string name)
        {
            FuelEntity fuelEntity = new FuelEntity { Name = name };

            await dbContext.Fuel.AddAsync(fuelEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.Fuel.AnyAsync(f => f.Id == fuelEntity.Id))
            {
                return AddResult.Success;
            }

            return AddResult.Failed;
        }

        public async Task<DeleteResult> DeleteRecord(int recordId)
        {
            FuelEntity fuelEntity = await dbContext.Fuel.FirstOrDefaultAsync(a => a.Id == recordId);

            if (fuelEntity == null)
            {
                return DeleteResult.RecordNotFound;
            }

            dbContext.Fuel.Remove(fuelEntity);
            await dbContext.SaveChangesAsync();

            if (!await dbContext.Fuel.AnyAsync(a => a.Id == fuelEntity.Id))
            {
                return DeleteResult.Success;
            }

            return DeleteResult.Failed;
        }

        public Task<EditResult> EditRecord(int recordId, string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string[]>> GetDataAsync()
        {
            List<string[]> data = new List<string[]>();

            foreach (var fuel in dbContext.Fuel)
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = fuel.Id.ToString();
                data[data.Count - 1][1] = fuel.Name.ToString();
            }

            return await Task.FromResult(data);
        }
    }
}