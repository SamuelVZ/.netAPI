using dotnetAPI.Data;
using dotnetAPI.model;

namespace dotnetAPI.Repositories {
    public class RegionRepositoryImpl : RegionRepository {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepositoryImpl(NZWalksDbContext nZWalksDbContext) {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public IEnumerable<Region> GetAll() {
            return nZWalksDbContext.Regions.ToList();
        }
    }
}
