using CRUDCovidWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCovidWeb.DAO
{
    public class AppContext : DbContext
    {
        private string conn = "Password=Wcogeomtgeo3027;Persist Security Info=True;User ID=sa;Initial Catalog=CovidWebConsultas;Data Source=192.168.0.133,1433";
        public DbSet<Paciente> Pacientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
