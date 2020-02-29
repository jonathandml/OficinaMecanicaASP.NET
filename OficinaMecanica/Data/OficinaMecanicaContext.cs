using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OficinaMecanica.Models;

namespace OficinaMecanica.Data
{
    public class OficinaMecanicaContext : DbContext
    {
        public OficinaMecanicaContext (DbContextOptions<OficinaMecanicaContext> options)
            : base(options)
        {
        }

        public DbSet<OficinaMecanica.Models.Estimate> Estimate { get; set; }
    }
}
