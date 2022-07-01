using webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace webapi.Services;

public static class DatabaseManagementService
{
    public static void StartMigrations(this IApplicationBuilder app)
    {
        using(var serviceScope = app.ApplicationServices.CreateScope()){
            var serviceDb = serviceScope.ServiceProvider.GetService<AppDbContext>();
            serviceDb.Database.Migrate();
        }
    }
}