using Microsoft.AspNetCore.Mvc;
using WebApp_DB.Entidades;
using WebApp_DB.Models;

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
        public IActionResult SalvarDados(CategoriaViewModel dados)
        {
            Categoria entidade = new Categoria();
            entidade.Nome = dados.Nome;
            entidade.Id = dados.Id;
            entidade.Ativo = dados.Ativo == "on" ? true : false;

            db.Categorias.Add(entidade);
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
