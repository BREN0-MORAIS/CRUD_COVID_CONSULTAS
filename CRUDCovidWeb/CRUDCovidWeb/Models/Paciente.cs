using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCovidWeb.Models
{
    public class Paciente
    {
        [Key]
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string  MedicoId { get; set; }
        public DateTime HoraConsulta { get; set; }
        public DateTime DataConsulta { get; set; }
    }
}
