using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CloudPucSimpleApi.Models;

namespace CloudPucSimpleApi.Controllers
{
    public class ProdutoController : ApiController
    {
        ProdutoModel[] produtos = new ProdutoModel[]
        {
            new ProdutoModel { Id = 1, Nome = "Ketchup Americano Heinz 397g", Categoria = "Condimentos", Departamento = "Mercearia", Preco = 7.99, UrlImagem = "https://www.supernossoemcasa.com.br/e-commerce/api/doc/produto/104089/img/main_image/0/104089_430.jpg?width=160&height=160"},
            new ProdutoModel { Id = 2, Nome = "Molho Americano Heinz Barbecue Original Pet", Categoria = "Condimentos", Departamento = "Mercearia", Preco = 19.90, UrlImagem = "https://www.supernossoemcasa.com.br/e-commerce/api/doc/produto/160518/img/main_image/0/160518_430.jpg?width=160&height=160"},
            new ProdutoModel { Id = 3, Nome = "Amaciante Diluído Comfort Claissc 2L", Categoria = "Desinfetantes", Departamento = "Limpeza", Preco = 7.41, UrlImagem = "https://www.supernossoemcasa.com.br/e-commerce/api/doc/produto/2400/img/main_image/0/2400_430.jpg?width=160&height=160"},
            new ProdutoModel { Id = 4, Nome = "Sabonete em Barra Dove Original 90g", Categoria = "Sabonetes", Departamento = "Limpeza", Preco = 1.98, UrlImagem = "https://www.supernossoemcasa.com.br/e-commerce/api/doc/produto/108542/img/main_image/0/108542.jpg?width=160&height=160"},
            new ProdutoModel { Id = 5, Nome = "Leite Longa Vida Cemil Desnatado Tetra Pak 1L", Categoria = "Leites", Departamento = "Laticínios", Preco = 2.78, UrlImagem = "https://www.supernossoemcasa.com.br/e-commerce/api/doc/produto/78274/img/main_image/0/78274_430.jpg?width=160&height=160"},
            new ProdutoModel { Id = 6, Nome = "Leite Longa Vida Cemil Integral Tetra Pak 1L", Categoria = "Leites", Departamento = "Laticínios", Preco = 2.78, UrlImagem = "https://www.supernossoemcasa.com.br/e-commerce/api/doc/produto/78282/img/main_image/0/78282_430.jpg?width=160&height=160"},
        };

        public IEnumerable<ProdutoModel> GetAllProdutos()
        {
            return produtos;
        }

        public IHttpActionResult GetProduto(int id)
        {
            var produto = produtos.FirstOrDefault((p) => p.Id == id);            

            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }
    }
}
