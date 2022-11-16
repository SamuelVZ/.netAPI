using dotnetAPI.model;

namespace dotnetAPI.Repositories {
    public interface RegionRepository {
        //Task to use it as asyncronous
        Task<IEnumerable<Region>> GetAll();
        Task<Region> GetById(int id);
        Task<Region> AddRegion(Region region);
        Task<Boolean> DeleteRegion(int id);
        Task<Region> UpdateRegion(Region region);
    }
}
