using cricbuzzz.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cricbuzzz.Data
{
    public class CricBuzzDataContext : DbContext
    {
        public CricBuzzDataContext(DbContextOptions<CricBuzzDataContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Tour> Tours { get; set; }

        public DbSet<TestRanking> TestRankings { get; set; }

        public DbSet<OdiRanking> OdiRankings { get; set; }
    }
}
