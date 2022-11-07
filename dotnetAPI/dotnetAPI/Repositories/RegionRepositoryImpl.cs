using dotnetAPI.Data;
using dotnetAPI.model;
using Microsoft.EntityFrameworkCore;

namespace dotnetAPI.Repositories {
    public class RegionRepositoryImpl : RegionRepository {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepositoryImpl(NZWalksDbContext nZWalksDbContext) {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public async Task<IEnumerable<Region>> GetAll() {
            return await nZWalksDbContext.Regions.ToListAsync();
        }

        public async Task<Region> GetById(int id) {
            return await nZWalksDbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
