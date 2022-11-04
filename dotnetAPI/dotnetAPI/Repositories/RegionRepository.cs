using dotnetAPI.model;

namespace dotnetAPI.Repositories {
    public interface RegionRepository {

        IEnumerable<Region> GetAll();
    }
}
