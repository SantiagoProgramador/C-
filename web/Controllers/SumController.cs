using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;
public class SumController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Calculate(int number1, int number2)
  {
    ViewBag.Result = number1 + number2;
    return View("Index");
  }
}
