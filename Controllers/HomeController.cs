using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;

public class HomeController : Controller
{   
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("")]
    public IActionResult Success(User user)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("success");
        }
        else
        {
            return View("Index");
        }
    }

    [HttpGet("success")]
    public IActionResult Success()
    {
        return View("success");
    }

}
