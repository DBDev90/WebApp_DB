using Microsoft.AspNetCore.Mvc;

namespace WebApp_DB.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
