using DivulgaTudo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DivulgaTudo.Controllers
{
    public class DivulgaTudoContext : DbContext
    {

        public DivulgaTudoContext() : base("DefaultConnection")
        { }

        // Pega do Model passado ao "DbSet" e cria a tabela com o nome especificado a frente
        //public DbSet<Anuncios> anuncios { get; set; }
        public System.Data.Entity.DbSet<DivulgaTudo.Models.Anuncios> Anuncios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // retira a convenção que pluraliza as tabelas no DB
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}