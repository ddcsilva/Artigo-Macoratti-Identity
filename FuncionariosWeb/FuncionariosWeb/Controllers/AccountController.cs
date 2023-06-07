using Microsoft.AspNetCore.Mvc;

namespace FuncionariosWeb.Controllers;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
}