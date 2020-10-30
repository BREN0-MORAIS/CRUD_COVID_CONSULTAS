using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCovidWeb.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
    }
}
