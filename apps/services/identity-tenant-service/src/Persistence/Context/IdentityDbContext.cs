using InfraIQ.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfraIQ.Persistence.Context;

public sealed class IdentityDbContext(
    DbContextOptions<IdentityDbContext> options) : DbContext(options)
{
    public DbSet<Tenant> Tenants => Set<Tenant>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var tenant = modelBuilder.Entity<Tenant>();

        tenant.ToTable("tenant");
        tenant.HasKey(x => x.Id);

        tenant.Property(x => x.Id)
            .HasColumnName("id")
            .HasDefaultValueSql("gen_random_uuid()");

        tenant.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(200)
            .IsRequired();

        tenant.Property(x => x.Code)
            .HasColumnName("code")
            .HasMaxLength(100)
            .IsRequired();

        tenant.HasIndex(x => x.Code).IsUnique();

        tenant.Property(x => x.Status)
            .HasColumnName("status")
            .HasMaxLength(20)
            .HasDefaultValue("active")
            .IsRequired();

        tenant.Property(x => x.CreatedAt)
            .HasColumnName("created_at")
            .HasDefaultValueSql("now()");
    }
}