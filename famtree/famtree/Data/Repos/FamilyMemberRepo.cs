using famtree.Data.Models;
using famtree.Data.RepoInterfaces;
using Microsoft.EntityFrameworkCore;

namespace famtree.Data.Repos;

public class FamilyMemberRepo : IFamilyMemberRepo
{
	private readonly AppDbContext _db;

  public FamilyMemberRepo(AppDbContext db)
  {
		_db = db;
  }

  public bool Add(FamilyMember familyMember)
	{
		_db.FamilyMembers.Add(familyMember);
		return Save();
	}

	public bool Delete(FamilyMember familyMember)
	{
		_db.FamilyMembers.Remove(familyMember);
		return Save();
	}

	public async Task<List<FamilyMember>> GetAllAsync()
	{
		return await _db.FamilyMembers.ToListAsync();
	}

	public async Task<FamilyMember> GetByIdAsync(int id)
	{
		return await _db.FamilyMembers.FindAsync(id);
	}

  public async Task<string> GetPartnersNameAsync(int partnersId)
  {
    FamilyMember partner = await _db.FamilyMembers.FindAsync(partnersId);
		return partner.FirstName + partner.LastName;
  }

  public bool Save()
	{
		int numSaved = _db.SaveChanges(); // returns the number of entries written to the database
		return numSaved > 0;
	}

	public bool Update(FamilyMember familyMember)
	{
		_db.Update(familyMember);
		return Save();
	}
}
