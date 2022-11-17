using dotnetAPI.model;

namespace dotnetAPI.Repositories {
    public interface WalksRepository {
        Task<IEnumerable<Walk>> GetAllWalks();
        Task<Walk> GetWalkById(int id);
        Task<Boolean> DelelteWalk(int id);
        Task<Walk> AddWalk(Walk walk);
        Task<Walk> UpdateWalk(Walk walk);

    }
}
