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
    public class TransportModelManager : ITransportModelManager
    {
        private readonly DatabaseContext dbContext;

        internal TransportModelManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AddResult> AddRecord(string name)
        {
            TransportModelEntity transportModelEntity = new TransportModelEntity { Name = name };

            await dbContext.TransportModels.AddAsync(transportModelEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.TransportModels.AnyAsync(tm => tm.Id == transportModelEntity.Id))
            {
                return AddResult.Success;
            }

            return AddResult.Failed;
        }

        public async Task<DeleteResult> DeleteRecord(int recordId)
        {
            TransportModelEntity transportModelEntity = await dbContext.TransportModels.FirstOrDefaultAsync(a => a.Id == recordId);

            if (transportModelEntity == null)
            {
                return DeleteResult.RecordNotFound;
            }

            dbContext.TransportModels.Remove(transportModelEntity);
            await dbContext.SaveChangesAsync();

            if (!await dbContext.TransportModels.AnyAsync(a => a.Id == transportModelEntity.Id))
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

            foreach (var model in dbContext.TransportModels)
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = model.Id.ToString();
                data[data.Count - 1][1] = model.Name.ToString();
            }

            return await Task.FromResult(data);
        }
    }
}