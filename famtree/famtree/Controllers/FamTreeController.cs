using famtree.Data.Models;
using famtree.Data.RepoInterfaces;
using famtree.Services;
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
		ViewData[Str.Fam] = await _memberRepo.GetAllAsync();
		return View();
	}

	public async Task<IActionResult> MemberProfile(int memberId)
	{
    var member = await _memberRepo.GetByIdAsync(memberId);
    //ViewData["partner"] = await _memberRepo.GetPartnersNameAsync(member.PartnerId);

		return View(member);
	}

  public async Task<IActionResult> EditMember(int memberId)
  {
    var member = await _memberRepo.GetByIdAsync(memberId);
    return View(member);
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult EditMember(FamilyMember member)
  {
    if (ModelState.IsValid)
    {
      _memberRepo.Update(member);
      return RedirectToAction(Str.FamTree);
    }
    return View(member);
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
      return RedirectToAction(Str.FamTree);
    }
    return View(member);
  }

  public async Task<IActionResult> DeleteMember(int memberId)
  {
    var member = await _memberRepo.GetByIdAsync(memberId);
    return View(member);
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult DeleteMember(FamilyMember member)
  {
    _memberRepo.Delete(member);
    return RedirectToAction(Str.FamTree);
  }
}
