
using Microsoft.EntityFrameworkCore;

namespace WebDemo.Data;

public partial class EfdemoContext : DbContext
{
    public EfdemoContext()
    {
    }

    public EfdemoContext(DbContextOptions<EfdemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Donation> Donations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database = EFDemo;User Id=sa;Password=NotPassword;Trusted_Connection=True;TrustServerCertificate=true;");
    */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Donation>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Donations_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.Donations).HasForeignKey(d => d.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
