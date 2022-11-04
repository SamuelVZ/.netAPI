using dotnetAPI.model;
using Microsoft.EntityFrameworkCore;

namespace dotnetAPI.Data {
    public class NZWalksDbContext : DbContext {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options) {

        }
        //DbSet is to create a table in the DB if it does not exist
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
