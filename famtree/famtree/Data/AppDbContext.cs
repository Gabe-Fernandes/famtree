using famtree.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace famtree.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

  public DbSet<FamilyMember> FamilyMembers { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
	}
}
