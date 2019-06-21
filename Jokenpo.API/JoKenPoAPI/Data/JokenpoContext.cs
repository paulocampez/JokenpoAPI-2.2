using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoKenPoAPI.Data
{
    public class JokenpoContext : DbContext
    {
        public JokenpoContext(DbContextOptions<JokenpoContext> options) : base(options)
        {

        }

        //public DbSet<Funcionarios> Funcionarios { get; set; }
    }
}
