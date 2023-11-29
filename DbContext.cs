using System;
using Microsoft.EntityFrameworkCore;

namespace Brandon.Expirements
{
    public class AppContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;

            optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer("data source=localhost;initial catalog=dbo;TrustServerCertificate=True;integrated security=True;");
        }
    }
}
