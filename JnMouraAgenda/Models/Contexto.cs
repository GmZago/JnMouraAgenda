using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JnMouraAgenda.Models
{
    public class Contexto : DbContext
    {
        public Contexto(): base("AplicacaoGabrelZagoBD") 
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());
        }

        public DbSet<DadosAgenda> DadosAgenda { get; set; }
    }
}