using CustodianPolicyRenewal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustodianPolicyRenewal.Controllers
{
	public class HomeController : Controller
	{
		
		[HttpGet]
		public IActionResult Index()
		{
        return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
    public IActionResult Index(PolicyViewModel model)
    {
      return RedirectToAction("Verification");
    }

    [HttpGet]
    public IActionResult Verification()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Verification(OtpModel model)
    {
      return View("PolicyDetails");
    }

    [HttpGet]
    public IActionResult PolicyDetails()
    {
      return View();
    }

    [HttpPost]
    public IActionResult PolicyDetails(PolicyDetail model)
    {
      return RedirectToAction("PaymentConfirmation", model);
    }

    [HttpGet]
    public IActionResult PaymentConfirmation()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}