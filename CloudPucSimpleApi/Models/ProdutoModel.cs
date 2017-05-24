namespace CloudPucSimpleApi.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Departamento { get; set; }
        public string UrlImagem { get; set; }
        public double Preco { get; set; }
    }
}