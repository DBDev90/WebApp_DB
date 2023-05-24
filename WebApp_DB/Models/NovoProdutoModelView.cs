using WebApp_DB.Entidades;

namespace WebApp_DB.Models
{
    public class NovoProdutoModelView : Produtos
    {
        public NovoProdutoModelView()
        {
            ListaCategorias = new List<Categoria>();
        }
        public List<Categoria> ListaCategorias {  get; set; }
    }
}
