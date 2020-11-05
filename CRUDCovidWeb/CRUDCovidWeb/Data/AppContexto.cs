using CRUDCovidWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCovidWeb.Data
{
    public class AppContexto : DbContext
    {
        private string conn = "Password=BRENOMORAIS2930;Persist Security Info=True;User ID=sa;Initial Catalog=CovidWeb;Data Source=192.168.1.133,1733";
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conn);
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos{ get; set; }   
    }
}
