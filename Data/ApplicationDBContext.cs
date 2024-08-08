using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<ServiceOrder> ServiceOrders { get; set; }
    public DbSet<People> People { get; set; }
    public DbSet<Article> Articles { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
{
 /*    // User-Role relationship
    modelBuilder.Entity<User>()
        .HasOne(u => u.Role)
        .WithMany(r => r.Users)
        .HasForeignKey(u => u.RoleId)
        .OnDelete(DeleteBehavior.Restrict);  // Change cascade to restrict or no action

    // Role-Permission relationship
    modelBuilder.Entity<Role>()
        .HasMany(r => r.Permissions)
        .WithOne(p => p.Role)
        .HasForeignKey(p => p.RoleId)
        .OnDelete(DeleteBehavior.Restrict);  // Avoid cascade issues

    // Company-User relationship
   modelBuilder.Entity<Company>()
        .HasMany(c => c.Users)
        .WithOne()
        .HasForeignKey(u => u.CompanyId)
        .OnDelete(DeleteBehavior.Restrict);  // Change cascade to restrict or no action

    // Company-People relationship
    modelBuilder.Entity<Company>()
        .HasMany(c => c.People)
        .WithOne(p => p.Company)
        .HasForeignKey(p => p.CompanyId)
        .OnDelete(DeleteBehavior.Restrict);  // Avoid cascade issues

    // ServiceOrder-Company relationship
    modelBuilder.Entity<ServiceOrder>()
        .HasOne(so => so.Company)
        .WithMany(c => c.ServiceOrders)
        .HasForeignKey(so => so.CompanyId)
        .OnDelete(DeleteBehavior.Restrict);  // Avoid cascade issues

    // ServiceOrder-People relationship
    modelBuilder.Entity<ServiceOrder>()
        .HasOne(so => so.People)
        .WithMany(p => p.ServiceOrders)
        .HasForeignKey(so => so.PeopleId)
        .OnDelete(DeleteBehavior.Restrict);  // Avoid cascade issues

    // ServiceOrder-User relationship
    modelBuilder.Entity<ServiceOrder>()
        .HasOne(so => so.User)
        .WithMany(u => u.ServiceOrders)
        .HasForeignKey(so => so.UserId)
        .OnDelete(DeleteBehavior.Restrict);  // Avoid cascade issues

    // ServiceOrder-Article relationship
    modelBuilder.Entity<ServiceOrder>()
        .HasMany(so => so.Articles)
        .WithMany(a => a.ServiceOrders)
        .UsingEntity(j => j.ToTable("ServiceOrderArticle"));

    // User-Article relationship
    modelBuilder.Entity<User>()
        .HasMany(u => u.CreatedArticles)
        .WithOne(a => a.CreatedBy)
        .HasForeignKey(a => a.CreatedById)
        .OnDelete(DeleteBehavior.Restrict);  // Avoid cascade issues

    // User-People relationship
    modelBuilder.Entity<User>()
        .HasMany(u => u.InteractedPeople)
        .WithMany(p => p.Users)
        .UsingEntity(j => j.ToTable("UserPeople"));

        modelBuilder.Entity<Article>()
    .HasOne(a => a.CreatedBy)
    .WithMany(u => u.CreatedArticles)
    .HasForeignKey(a => a.CreatedById)
    .OnDelete(DeleteBehavior.Restrict);
*/
}
}