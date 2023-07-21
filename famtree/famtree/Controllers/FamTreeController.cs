using famtree.Data.Models;
using famtree.Data.RepoInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace famtree.Controllers;

public class FamTreeController : Controller
{
	private readonly IFamilyMemberRepo _memberRepo;

  public FamTreeController(IFamilyMemberRepo memberRepo)
  {
    _memberRepo = memberRepo;
  }

  public async Task<IActionResult> FamTree()
	{
		ViewData["fam"] = await _memberRepo.GetAllAsync();
		return View();
	}

	public async Task<IActionResult> MemberProfile(int memberId)
	{
		//var member = await _memberRepo.GetByIdAsync(memberId);
		//ViewData["partner"] = await _memberRepo.GetPartnersNameAsync(member.PartnerId);
		ViewData["member"] = await _memberRepo.GetByIdAsync(memberId);
		return View();
	}

  public IActionResult AddMember()
  {
    return View();
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult AddMember(FamilyMember member)
  {
    if (ModelState.IsValid)
    {
      _memberRepo.Add(member);
      return RedirectToAction("FamTree");
    }
    return View(member);
  }
}
