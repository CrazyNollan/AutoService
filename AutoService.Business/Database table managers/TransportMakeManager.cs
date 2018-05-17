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
    public class TransportMakeManager : ITransportMakeManager
    {
        private readonly DatabaseContext dbContext;

        internal TransportMakeManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AddResult> AddRecord(string name)
        {
            TransportMakeEntity transportMakeEntity = new TransportMakeEntity { Name = name };

            await dbContext.TransportMakes.AddAsync(transportMakeEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.TransportMakes.AnyAsync(tm => tm.Id == transportMakeEntity.Id))
            {
                return AddResult.Success;
            }

            return AddResult.Failed;
        }

        public async Task<DeleteResult> DeleteRecord(int recordId)
        {
            TransportMakeEntity transportMakeEntity = await dbContext.TransportMakes.FirstOrDefaultAsync(a => a.Id == recordId);

            if (transportMakeEntity == null)
            {
                return DeleteResult.RecordNotFound;
            }

            dbContext.TransportMakes.Remove(transportMakeEntity);
            await dbContext.SaveChangesAsync();

            if (!await dbContext.TransportMakes.AnyAsync(a => a.Id == transportMakeEntity.Id))
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

            foreach (var make in dbContext.TransportMakes)
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = make.Id.ToString();
                data[data.Count - 1][1] = make.Name.ToString();
            }

            return await Task.FromResult(data);
        }
    }
}