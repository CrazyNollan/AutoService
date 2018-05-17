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
    public class ClientManager : IClientManager
    {
        private readonly DatabaseContext dbContext;

        internal ClientManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AddResult> AddRecord(string name, string surname, string patronymic, string email, int addressId)
        {
            ClientEntity clientEntity = new ClientEntity { Name = name, Surname = surname, Patronymic = patronymic, Email = email, AddressId = addressId };

            await dbContext.Clients.AddAsync(clientEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.Clients.AnyAsync(c => c.Id == clientEntity.Id))
            {
                return AddResult.Success;
            }

            return AddResult.Failed;
        }

        public async Task<DeleteResult> DeleteRecord(int recordId)
        {
            ClientEntity clientEntity = await dbContext.Clients.FirstOrDefaultAsync(a => a.Id == recordId);

            if (clientEntity == null)
            {
                return DeleteResult.RecordNotFound;
            }

            dbContext.Clients.Remove(clientEntity);
            await dbContext.SaveChangesAsync();

            if (!await dbContext.Clients.AnyAsync(a => a.Id == clientEntity.Id))
            {
                return DeleteResult.Success;
            }

            return DeleteResult.Failed;
        }

        public Task<EditResult> EditRecord(int recordId, string name, string surname, string patronymic, string email, int addressId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string[]>> GetDataAsync()
        {
            List<string[]> data = new List<string[]>();

            foreach (var client in dbContext.Clients)
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = client.Id.ToString();
                data[data.Count - 1][1] = client.Name.ToString();
                data[data.Count - 1][2] = client.Surname.ToString();
                data[data.Count - 1][3] = client.Patronymic.ToString();
                data[data.Count - 1][4] = client.Email.ToString();
                data[data.Count - 1][5] = client.AddressId.ToString();
            }

            return await Task.FromResult(data);
        }
    }
}