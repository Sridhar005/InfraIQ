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
                "Set ConnectionStrings__IdentityDb before running EF tools.");

        var options = new DbContextOptionsBuilder<IdentityDbContext>()
            .UseNpgsql(
                connectionString,
                x => x.MigrationsAssembly("InfraIQ.Migrations"))
            .Options;

        return new IdentityDbContext(options);
    }
}