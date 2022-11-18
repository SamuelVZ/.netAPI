using dotnetAPI.model;
using dotnetAPI.Repositories;

namespace dotnetAPI.Service {
    public class WalkServiceImpl : WalkService {
        private readonly WalksRepository walksRepository;

        public WalkServiceImpl(WalksRepository walksRepository) {
            this.walksRepository = walksRepository;
        }

        public async Task<bool> DelelteWalk(int id) {
            var walk = await GetWalkById(id);
            if (walk == null) { return false; }

            await walksRepository.DelelteWalk(walk);

            return true;
            
        }

        public async Task<IEnumerable<Walk>> GetAll() {
            return await walksRepository.GetAllWalks();
        }

        public async Task<Walk> GetWalkById(int id) {
            return await walksRepository.GetWalkById(id);
        }
    }
}
