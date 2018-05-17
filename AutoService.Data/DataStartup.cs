using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AutoService.Data
{
    public static class DataStartup
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            ConfigureServices(connectionString);
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));
        }

        private static void ConfigureServices(string connectionString)
        {
            DbContextOptionsBuilder<DatabaseContext> contextOptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            contextOptionsBuilder.UseSqlServer(connectionString);
            DbContextOptions<DatabaseContext> options = contextOptionsBuilder.Options;
            using (var context = new DatabaseContext(options))
            {
                context.Database.Migrate();
            }
        }
    }
}