using dotnetAPI.model;
using dotnetAPI.Repositories;

namespace dotnetAPI.Service {
    public class WalkServiceImpl : WalkService {
        private readonly WalksRepository walksRepository;

        public WalkServiceImpl(WalksRepository walksRepository) {
            this.walksRepository = walksRepository;
        }
        public async Task<IEnumerable<Walk>> GetAll() {
            return await walksRepository.GetAllWalks();
        }
    }
}
