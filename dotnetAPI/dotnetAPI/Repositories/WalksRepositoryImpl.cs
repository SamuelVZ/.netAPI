using dotnetAPI.Data;
using dotnetAPI.model;
using Microsoft.EntityFrameworkCore;

namespace dotnetAPI.Repositories {
    public class WalksRepositoryImpl : WalksRepository {
        private readonly NZWalksDbContext nZWalksDbContext;

        public WalksRepositoryImpl(NZWalksDbContext nZWalksDbContext) {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public Task<Walk> AddWalk(Walk walk) {
            throw new NotImplementedException();
        }

        public Task<bool> DelelteWalk(int id) {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Walk>> GetAllWalks() {
            return await nZWalksDbContext.Walks.ToListAsync();
        }

        public Task<Walk> GetWalkById(int id) {
            throw new NotImplementedException();
        }

        public Task<Walk> UpdateWalk(Walk walk) {
            throw new NotImplementedException();
        }
    }
}
