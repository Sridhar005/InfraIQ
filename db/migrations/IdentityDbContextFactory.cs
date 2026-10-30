using InfraIQ.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace InfraIQ.Migrations;

public sealed class IdentityDbContextFactory
    : IDesignTimeDbContextFactory<IdentityDbContext>
{
    public IdentityDbContext CreateDbContext(string[] args)
    {
        var connectionString =
            Environment.GetEnvironmentVariable("ConnectionStrings__IdentityDb")
            ?? throw new InvalidOperationException(
                "Set the ConnectionStrings__IdentityDb environment variable.");

        var options = new DbContextOptionsBuilder<IdentityDbContext>()
            .UseNpgsql(
                connectionString,
                options => options.MigrationsAssembly("InfraIQ.Migrations"))
            .Options;

        return new IdentityDbContext(options);
    }
}