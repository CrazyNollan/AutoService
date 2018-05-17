using AutoService.Business.Enums;
using AutoService.Business.Interfaces;
using AutoService.Data;
using AutoService.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AutoService.Business
{
    public class UserManager : IUserManager
    {
        private readonly DatabaseContext dbContext;

        internal UserManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<LoginResult> LoginAsync(string login, string password)
        {
            if (await dbContext.Users.AnyAsync(u => u.Login == login && u.Password == password))
            {
                return LoginResult.Success;
            }

            return LoginResult.Failed;
        }

        public async Task<RegisterResult> RegisterAsync(string name, string surname, int tokenNumber, string login, string password)
        {
            if (await dbContext.Users.AnyAsync(u => u.TokenNumber == tokenNumber))
            {
                return RegisterResult.TokenExists;
            }

            if (await dbContext.Users.AnyAsync(u => u.Login == login))
            {
                return RegisterResult.LoginExists;
            }

            UserEntity userEntity = new UserEntity { Name = name, Surname = surname, TokenNumber = tokenNumber, Login = login, Password = password };
            await dbContext.Users.AddAsync(userEntity);
            await dbContext.SaveChangesAsync();

            if (await dbContext.Users.AnyAsync(u => u.Id == userEntity.Id))
            {
                return RegisterResult.Success;
            }

            return RegisterResult.Failed;
        }
    }
}