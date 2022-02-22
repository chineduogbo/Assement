using COUREAssessment.ModelLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COUREAssessment.DataLayer
{
    public class CoureContext : DbContext
    {
        public CoureContext(DbContextOptions<CoureContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<CountryDetail> CountryDetails { get; set; }
    }
}
