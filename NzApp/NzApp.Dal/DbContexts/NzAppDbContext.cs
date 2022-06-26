using Microsoft.EntityFrameworkCore;
using NzApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NzApp.Dal.DbContexts
{
    public class NzAppDbContext : DbContext
    {
        public NzAppDbContext(DbContextOptions<NzAppDbContext> options) : base(options)
        {

        }

        public DbSet<Walk> Walks { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
