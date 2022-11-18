using dotnetAPI.model;

namespace dotnetAPI.Service {
    public interface WalkService {
        Task<IEnumerable<Walk>> GetAll();
        Task<Walk> GetWalkById(int id);
    }
}
