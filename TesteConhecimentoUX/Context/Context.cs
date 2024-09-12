using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TesteConhecimentoUX.Models;

namespace TesteConhecimentoUX.Context
{
    public class Context : DbContext
    {
        public Context() : base("BancoDeDados") 
        { 
        
        }

        public DbSet<Participante> Participante { get; set; }
        public DbSet<Pacote> Pacote { get; set; }
        public DbSet<Atividade> Atividade { get; set; }
    }
}