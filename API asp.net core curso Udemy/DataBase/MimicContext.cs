using API_asp.net_core_curso_Udemy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_asp.net_core_curso_Udemy.DataBase
{
    public class MimicContext :DbContext
    {
        public MimicContext(DbContextOptions<MimicContext>options):base(options)
        {                
        }
        public DbSet<Palavra> Palavras{ get; set; }
    }
}
