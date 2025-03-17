namespace Pc_Express.Models
{
    public class Pecas
    {
        public int PecasID { get; set; }
        public string nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string imagemUrl { get; set; }
        public string imagemThumbnailUrl { get; set; }
        public bool Ispecapreferida { get; set; }
        public bool EmEstoque { get; set; }

        public int categoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
