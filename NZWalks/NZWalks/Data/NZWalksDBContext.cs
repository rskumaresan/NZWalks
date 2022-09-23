using Microsoft.EntityFrameworkCore;
using NZWalks.Models.Domain;
using System.Data.Common;

namespace NZWalks.Data
{
    public class NZWalksDBContext: DbContext    
    {
        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> options) : base(options)

        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
               public DbSet<WalkDifficulty> WalkDifficultys { get; set; }

    }
}
