using Microsoft.AspNetCore.Mvc;
using WebApp_DB.Entidades;

namespace WebApp_DB.Controllers
{
    public class CategoriasController : Controller
    {
        //CONEXÃO COM O BANCO
        private Contexto db;
        public CategoriasController(Contexto _db)
        {
            this.db = _db;
        }
        
        public IActionResult Lista()
        {
            return View(db.Categorias.ToList());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(Categoria dados)
        {
            db.Categorias.Add(dados);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {

            return RedirectToAction("Lista");
        }
    }
}
