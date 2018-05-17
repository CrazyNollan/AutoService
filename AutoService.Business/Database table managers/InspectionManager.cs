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
    public class InspectionManager : IInspectionManager
    {
        private readonly DatabaseContext dbContext;

        internal InspectionManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AddResult> AddRecord(string number, int startYear, int expireYear, bool isPassed, int transportId)
        {
            InspectionEntity inspectionEntity = new InspectionEntity { Number = number, StartYear = startYear, ExpireYear = expireYear, IsPassed = isPassed, TransportId = transportId };

            await dbContext.Inspections.AddAsync(inspectionEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.Inspections.AnyAsync(i => i.Id == inspectionEntity.Id))
            {
                return AddResult.Success;
            }

            return AddResult.Failed;
        }

        public async Task<DeleteResult> DeleteRecord(int recordId)
        {
            InspectionEntity inspectionEntity = await dbContext.Inspections.FirstOrDefaultAsync(a => a.Id == recordId);

            if (inspectionEntity == null)
            {
                return DeleteResult.RecordNotFound;
            }

            dbContext.Inspections.Remove(inspectionEntity);
            await dbContext.SaveChangesAsync();

            if (!await dbContext.Inspections.AnyAsync(a => a.Id == inspectionEntity.Id))
            {
                return DeleteResult.Success;
            }

            return DeleteResult.Failed;
        }

        public Task<EditResult> EditRecord(int recordId, string number, int startYear, int expireYear, bool isPassed, int transportId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string[]>> GetDataAsync()
        {
            List<string[]> data = new List<string[]>();

            foreach (var inspection in dbContext.Inspections)
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = inspection.Id.ToString();
                data[data.Count - 1][1] = inspection.Number.ToString();
                data[data.Count - 1][2] = inspection.StartYear.ToString();
                data[data.Count - 1][3] = inspection.ExpireYear.ToString();
                data[data.Count - 1][4] = inspection.IsPassed.ToString();
                data[data.Count - 1][5] = inspection.TransportId.ToString();
            }

            return await Task.FromResult(data);
        }
    }
}