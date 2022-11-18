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

        public async Task<bool> DelelteWalk(Walk walk) {
            

            nZWalksDbContext.Walks.Remove(walk);
            await nZWalksDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Walk>> GetAllWalks() {
            return await nZWalksDbContext.Walks.ToListAsync();
        }

        public async Task<Walk> GetWalkById(int id) {
            return await nZWalksDbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Walk> UpdateWalk(Walk walk) {
            throw new NotImplementedException();
        }
    }
}
