using Microsoft.AspNetCore.Mvc;

namespace famtree.Controllers;

public class FamTreeController : Controller
{
	public IActionResult FamTree()
	{
		return View();
	}

	public IActionResult MemberProfile()
	{
		return View();
	}
}
