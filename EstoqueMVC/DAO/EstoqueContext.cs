using CaelumEstoque.Models;
using EstoqueMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CaelumEstoque.DAO
{
    public class EstoqueContext : DbContext
    {

        public string path = @"Password=BRENOMORAIS2930;Persist Security Info=True;User ID=sa;Initial Catalog=Estoque;Data Source=DESKTOP-FUH39GV\BFMSERVER";
        public string path2 = @"Password=Wcogeomtgeo3027;Persist Security Info=True;User ID=sa;Initial Catalog=Estoque;Data Source=192.168.0.133,1433";
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaDoProduto> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(path2);

        }




    }
}