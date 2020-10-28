using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using CaelumEstoque.Filtros;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EstoqueMVC.Models;
using System;

namespace CaelumEstoque.Controllers
{
   // [AutorizacaoFilter]

    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {

            //instancia o dao de  ProdutosDAO
            ProdutosDAO dao = new ProdutosDAO();

            //cria uma variavel Ilist e adiciona a lista do dao 
            IList<Produto> produtos = dao.Lista();

            //cria uma viewBag com atributo Produtos que recebe uma lista de produtos
     

            //retorna a lista de produtos para a visuaiização de dados
            return View(produtos);
        }


        public ActionResult Form()
        {
            //retorna uma lista para adicionar na view form no item combobox
            //instancia o DAO categoria
            CategoriasDAO categoriasDao = new CategoriasDAO();

            //cria um Ilist de categoria e adiciona em um atributo categoria,
            //cria uma lista de categoria e chama o metodo de lista 
            IList<CategoriaDoProduto> categorias = categoriasDao.Lista();

            //cria uma view bag com atributo categoria e adiciona a lista de categoria
            ViewBag.Categorias = categorias;

            ViewBag.Produto = new Produto();
            //retorna a view bag, para poder chamar na visuaklzação
            return View();
        }

        //passa os dados do formularios para esse metodo que carrega todos os atributos do objeto

        //anotação para enviar só metodos do tipo Post que não passa dados na URL 
        [HttpPostAttribute]
        public ActionResult Adiciona(Produto produto)
        {

            int Idinformatica = 1;

            //se produto da categoria Id for igual ao Id da informatica e preço for menor que sem 
            if(produto.CategoriaId.Equals(Idinformatica) && produto.Preco < 100)
            {
                //Messagem de erro de validação, tm como primeiro parâmetro a chave e como segundo a menssagem
                ModelState.AddModelError("produto.invalido","informatica com preço abaixo de R$ 100");
            }
            //verifica se os dados preenchidos obedece a forma de validação das anotações do models
            if (ModelState.IsValid)
            {
                //instancia o dao 
                ProdutosDAO dao = new ProdutosDAO();

                //chama o metodo de adicionar o objeto 
                dao.Adiciona(produto);

                //retorna a view, para a camada de visualização

                //faz o redirecionamento para o Produto onde esta a listagem da tabela de dados
                return RedirectToAction("Index", "Produto");
            }
            else
            {
               //caso else pega o produto que veio da camada de visualização e adiciona em uma viewBag
                ViewBag.produto = produto;

                CategoriasDAO categoriasDAO = new CategoriasDAO();
                ViewBag.categorias = categoriasDAO.Lista();
                //se a requisição acima não for de acordo, mostra novamente o formulaio para o usuário 
                return View("Form");
            }
          
        }

       //buscando um produto por Id para mostrar os detalhes 
     
        public ActionResult Visualizador(int Id)
        {
            //instanciando o dao para chamar o metodo de busca por Id
            ProdutosDAO dao = new ProdutosDAO();
            //chamando o metodo busca por Id passa como parametro o produtoId
            Produto produto = dao.BuscaPorId(Id);

            //cria uma viewBag que recebe o Id do produto
            ViewBag.Produto = produto;

            return View();
        }

        public ActionResult DecrementarQTD(int Id)
        {
           ProdutosDAO dao = new ProdutosDAO();
           //pega o Id do Produto que deseja modificar
           Produto produto = dao.BuscaPorId(Id);
           //decrementa 
           produto.Quantidade--;
           //passa para o Metodo de atualizar
            dao.Atualiza(produto);
            //retorna para a pagina de produto

       

            return Json(produto);
        }


    }
}