using CaelumEstoque.Models;
using EstoqueMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaelumEstoque.DAO
{
    public class ProdutosDAO
    {

        [HttpPost]
        public void Adiciona(Produto produto)
        {
            if (produto != null)
            {
                using (var context = new EstoqueContext())
                {
                    context.Produtos.Add(produto);

                    context.SaveChanges();

                }
            }
        }

        public void Remover(Produto produto)
        {
            if (produto != null)
            {
                using (var context = new EstoqueContext())
                {
                    context.Produtos.Remove(produto);
                    context.SaveChanges();
                }
            }
        }
        public IList<Produto> Lista()
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Produtos.Include("Categoria").ToList();
            }
        }

        public Produto BuscaPorId(int id)
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Produtos.Include("Categoria")
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

        #region metodo atualiza do ALura
        //public void Atualiza(Produto produto)
        //{
        //    using (var contexto = new EstoqueContext())
        //    {
        //        contexto.Entry(produto);
        //        contexto.SaveChanges();
        //    }
        //}
        #endregion

        public void Atualiza(Produto produto)
        {
            using (var contexto = new EstoqueContext())
            {
                contexto.Entry(produto).State = EntityState.Modified;
                contexto.SaveChanges();
            }

        }


        

        }
    }