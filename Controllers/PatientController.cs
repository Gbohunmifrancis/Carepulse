using Microsoft.AspNetCore.Mvc;

namespace Carepulse_Backend.Controllers;

public class PatientController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}