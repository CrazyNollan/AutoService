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
    public class TransportManager : ITransportManager
    {
        private readonly DatabaseContext dbContext;

        internal TransportManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AddResult> AddRecord(string number, int transportMakeId, int transportModelId, int fuelId, int transportCategoryId, int clientId)
        {
            TransportEntity transportEntity = new TransportEntity { Number = number, TransportMakeId = transportMakeId, TransportModelId = transportModelId, FuelId = fuelId, TransportCategoryId = transportCategoryId, ClientId = clientId };

            await dbContext.Transport.AddAsync(transportEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.Transport.AnyAsync(t => t.Id == transportEntity.Id))
            {
                return AddResult.Success;
            }

            return AddResult.Failed;
        }

        public async Task<DeleteResult> DeleteRecord(int recordId)
        {
            TransportEntity transportEntity = await dbContext.Transport.FirstOrDefaultAsync(a => a.Id == recordId);

            if (transportEntity == null)
            {
                return DeleteResult.RecordNotFound;
            }

            dbContext.Transport.Remove(transportEntity);
            await dbContext.SaveChangesAsync();

            if (!await dbContext.Transport.AnyAsync(a => a.Id == transportEntity.Id))
            {
                return DeleteResult.Success;
            }

            return DeleteResult.Failed;
        }

        public Task<EditResult> EditRecord(int recordId, string number, int transportMakeId, int transportModelId, int fuelId, int transportCategoryId, int clientId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string[]>> GetDataAsync()
        {
            List<string[]> data = new List<string[]>();

            foreach (var transport in dbContext.Transport)
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = transport.Id.ToString();
                data[data.Count - 1][1] = transport.Number.ToString();
                data[data.Count - 1][2] = transport.TransportMakeId.ToString();
                data[data.Count - 1][3] = transport.TransportModelId.ToString();
                data[data.Count - 1][4] = transport.FuelId.ToString();
                data[data.Count - 1][5] = transport.TransportCategoryId.ToString();
                data[data.Count - 1][6] = transport.ClientId.ToString();
            }

            return await Task.FromResult(data);
        }
    }
}