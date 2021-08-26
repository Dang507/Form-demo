using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProjAPI.Models
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options): base (options)
        {

        }
        public DbSet<Person>Persons  { get; set; }

    }
  
    
}
