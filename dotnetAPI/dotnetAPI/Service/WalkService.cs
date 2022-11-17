using dotnetAPI.model;

namespace dotnetAPI.Service {
    public interface WalkService {
        Task<IEnumerable<Walk>> GetAll();
    }
}
