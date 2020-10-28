using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaelumEstoque.DAO
{
    public class CategoriasDAO
    {
        //metodos para adicionar todos os produtos gravados 
        public void Adiciona(CategoriaDoProduto categoria)
        {
            using (var context = new EstoqueContext())
            {
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }
        }

        //metodo para listar toidos o0s produtos gravados
        public IList<CategoriaDoProduto> Lista()
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Categorias.ToList();
            }
        }
        //buscra produto por ID
        public CategoriaDoProduto BuscaPorId(int id)
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Categorias.Find(id);
            }
        }

        public void Atualiza(CategoriaDoProduto categoria)
        {
            using (var contexto = new EstoqueContext())
            {
              //  contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}