using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace EstoqueMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        // [StringLength(20)]

        //Required = define que o campo seja obrigatorio o Preenchimento
        //StringLength(20) = define que o campo tenha o numero maximo 20 caracteres 
        [Required, StringLength(20)]
        public String Nome { get; set; }

        public float Preco { get; set; }

        public CategoriaDoProduto Categoria { get; set; }

        public int? CategoriaId { get; set; }

        public String Descricao { get; set; }

        public int Quantidade { get; set; }
    }
}