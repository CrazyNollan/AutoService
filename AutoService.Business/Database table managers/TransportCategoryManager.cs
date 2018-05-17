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
    public class TransportCategoryManager : ITransportCategoryManager
    {
        private readonly DatabaseContext dbContext;

        internal TransportCategoryManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AddResult> AddRecord(string name)
        {
            TransportCategoryEntity transportCategoryEntity = new TransportCategoryEntity { Name = name };

            await dbContext.TransportCategories.AddAsync(transportCategoryEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.TransportCategories.AnyAsync(tc => tc.Id == transportCategoryEntity.Id))
            {
                return AddResult.Success;
            }

            return AddResult.Failed;
        }

        public async Task<DeleteResult> DeleteRecord(int recordId)
        {
            TransportCategoryEntity transportCategoryEntity = await dbContext.TransportCategories.FirstOrDefaultAsync(a => a.Id == recordId);

            if (transportCategoryEntity == null)
            {
                return DeleteResult.RecordNotFound;
            }

            dbContext.TransportCategories.Remove(transportCategoryEntity);
            await dbContext.SaveChangesAsync();

            if (!await dbContext.TransportCategories.AnyAsync(a => a.Id == transportCategoryEntity.Id))
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

            foreach (var category in dbContext.TransportCategories)
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = category.Id.ToString();
                data[data.Count - 1][1] = category.Name.ToString();
            }

            return await Task.FromResult(data);
        }
    }
}