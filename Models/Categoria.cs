namespace Pc_Express.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string CategoriaNome { get; set; }
        public string descricao { get; set; }

        public List<Pecas> Peças { get; set; }

    }
}
