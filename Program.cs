using System.Threading.Tasks;
using Brandon.Expirements;
using Microsoft.EntityFrameworkCore;

namespace ReproEF8MigrationProc
{
    public static class Program
    {
        public static async Task Main()
        {
            var ctx = new AppContext();
            await ctx.Database.MigrateAsync();
        }
    }
}
