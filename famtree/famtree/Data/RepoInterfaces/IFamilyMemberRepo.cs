using famtree.Data.Models;

namespace famtree.Data.RepoInterfaces;

public interface IFamilyMemberRepo
{
	Task<List<FamilyMember>> GetAllAsync();
	Task<FamilyMember> GetByIdAsync(int id);
	Task<string> GetPartnersNameAsync(int partnersId);
  bool Add(FamilyMember familyMember);
	bool Update(FamilyMember familyMember);
	bool Delete(FamilyMember familyMember);
	bool Save();
}
