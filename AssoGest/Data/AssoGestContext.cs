using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssoGest.Models;

namespace AssoGest.Data
{
    public class AssoGestContext : DbContext
    {
        public AssoGestContext (DbContextOptions<AssoGestContext> options)
            : base(options)
        {
        }

        public DbSet<AssoGest.Models.Departamento> Departamento { get; set; }
    }
}
