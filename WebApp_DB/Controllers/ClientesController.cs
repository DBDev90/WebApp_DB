using Microsoft.AspNetCore.Mvc;
using WebApp_DB.Models;

namespace WebApp_DB.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClienteViewModel> lista = new List<ClienteViewModel>();
        public IActionResult Lista()
        {
            //ClienteViewModel novo = new ClienteViewModel();
            //List<ClienteViewModel> lista = new List<ClienteViewModel>();

            //for (var i = 0; i < 15; i++)
            //{                
            //    novo.Nome = "Douglas Bordinassi";
            //    novo.Id = 10;
            //    novo.Telefone = "1699999 9999";

            //    lista.Add(novo);
            //}            
            

            return View(lista);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(ClienteViewModel model)
        {
            lista.Add(model);
            return RedirectToAction("Lista");
        }

        [HttpPost]
        public IActionResult Cadastro(string Nome, string Telefone)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                TempData["Erro"] = "O campo Nome não pode estar em branco!";
            }

            if (string.IsNullOrEmpty(Telefone))
            {
                TempData["Erro"] = "O campo Telefone não pode estar em branco!";
            }

            return View();
        }

        public IActionResult Editar(int id)
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {
            ClienteViewModel cliente = lista.Find(x => x.Id == id);
            if(cliente != null)
            {
                lista.Remove(cliente);
            }

            return RedirectToAction("Lista");
        }
    }
}
