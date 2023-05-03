using Microsoft.AspNetCore.Mvc;

namespace WebApp_DB.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados()
        {
            return RedirectToAction("Lista");
        }

        public IActionResult Editar()
        {
            return View();
        }
    }
}
